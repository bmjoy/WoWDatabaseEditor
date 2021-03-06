﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDE.Common.Managers;

namespace WDE.Common.Solution
{
    public interface ISolutionItemEditorProvider
    {

    }

    public interface ISolutionItemEditorProvider<T> : ISolutionItemEditorProvider where T : ISolutionItem
    {
        DocumentEditor GetEditor(T item);
    }
}
