﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Ultramarine.Generators.Tasks.Library.Contracts;
using Ultramarine.Workspaces;
using Ultramarine.Workspaces.CodeElements;

namespace Ultramarine.Generators.Tasks
{
    [Export(typeof(Task))]
    public class LoadCodeElement : Task
    {
        public string ElementName { get; set; }
        public ElementType? ElementType { get; set; }
        public ElementAccess? ElementAccess { get; set; }
        public ElementOverride? ElementOverride { get; set; }
        public string TypeOf { get; set; }

        protected override object OnExecute()
        {
            var result = new List<ICodeElementModel>();
            var input = Input as IEnumerable;
            if (input == null) return result;

            foreach (var item in input)
            {
                if (item is IProjectItemModel)
                {
                    var elements = ((IProjectItemModel)item).GetCodeElements(ElementName);
                    if (elements != null)
                        result.AddRange(elements);
                }
                //TODO: add any other type of inputs
            }

            result = FilterElements(result, ElementType, ElementAccess, ElementOverride, TypeOf);

            return result;
        }

        private List<ICodeElementModel> FilterElements(List<ICodeElementModel> elements, ElementType? type, ElementAccess? access, ElementOverride? @override, string typeOf = null)
        {
            var result = elements;
            if (type.HasValue)
                result = result.Where(e => e.Type == type).ToList();
            if (access.HasValue)
                result = result.Where(e => e.Access == access).ToList();
            if (@override.HasValue)
                result = result.Where(e => e.Override == @override).ToList();
            if (typeOf != null)
                result = result.Where(e => e.TypeOf != null && e.TypeOf.Any(t => Regex.IsMatch(t, typeOf))).ToList();

            return result;
        }
    }
}
