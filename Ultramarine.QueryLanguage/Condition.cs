﻿using System;
using Ultramarine.QueryLanguage.Comparers;
using StringComparer = Ultramarine.QueryLanguage.Comparers.StringComparer;
using StringComparison = Ultramarine.QueryLanguage.Comparers.StringComparison;

namespace Ultramarine.QueryLanguage
{
    public class Condition
    {
        public Condition(string @operator, string leftOperand, string rightOperand)
        {
            _comparer = ParseComparisonType(@operator);
            LeftOperand = leftOperand;
            RightOperand = rightOperand;            
        }
        private StringComparer _comparer { get; set; }
        public OperatorType OperatorType { get; set; }
        public string LeftOperand { get; set; }
        public string RightOperand { get; set; }

        public bool Evaluate()
        {
            return _comparer.Evaluate(LeftOperand, RightOperand);
        }

        private StringComparer ParseComparisonType(string @operator)
        {
            OperatorType = (OperatorType)Enum.Parse(typeof(OperatorType), @operator, true);
            return StringComparison.Instance.GetComparer(OperatorType);
        }
    }
}