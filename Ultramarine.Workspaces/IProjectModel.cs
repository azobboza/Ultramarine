﻿using System.Collections.Generic;

namespace Ultramarine.Workspaces
{
    public interface IProjectModel
    {
        string FilePath { get; set; }
        string Name { get; set; }
        string Language { get; set; }

        List<IProjectItemModel> ProjectItems { get; set; }

        IProjectItemModel CreateDirectory(string folderPath);

        IProjectItemModel CreateProjectItem(string path, string content, bool overwrite);
        IEnumerable<IProjectModel> GetProjects(string expression);
        IEnumerable<IProjectItemModel> GetProjectItems(string expression);
        IEnumerable<IProjectItemModel> GetProjectItems(string expression, string dependentUpon);
        bool Build(string configuration);
    }
}
