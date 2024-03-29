﻿using System.Collections.Generic;
using System.ComponentModel.Composition;
using ZeraSystems.CodeNanite.Expansion;
using ZeraSystems.CodeStencil.Contracts;

namespace ZeraSystems.CodeNanite.Cshtml
{
    /// <summary>
    /// There are 6 elements in the String Array used by the
    /// 0 - Publisher : This is the name of the publisher
    /// 1 - Title : This is the title of the Code Nanite
    /// 2 - Details : This is the
    /// 3 - Version Number
    /// 4 - Label : Label of the Code Nanite
    /// 5 - Namespace
    /// 6 - Release Date
    /// 7 - Name to use for Expander Label
    /// 8 - Indicates that the Nanite is Schema Dependent
    /// 9 - RESERVED
    /// 10 - RESERVED
    /// </summary>
    [Export(typeof(ICodeStencilCodeNanite))]
    [CodeStencilCodeNanite(new[]
    {
        "Zera Systems Inc.",                    // 0
        "Returns a @Html.Display tag",    // 1
        "..",                                   // 2
        "1.0",                                  // 3
        "CshtmlHtmlDisplay",                         // 4
        "ZeraSystems.CodeNanite.Cshtml",               // 5
        "10/10/2018",                           // 6
        "CS_CSHTML_HTML_DISPLAY",                        // 7
        "1",                                    // 8
        "",                                     // 9
        ""                                      // 10
    })]
    public partial class CshtmlHtmlDisplay : ExpansionBase, ICodeStencilCodeNanite
    {
        public string Input { get; set; }
        public string Output { get; set; }
        public int Counter { get; set; }
        public List<string> OutputList { get; set; }
        public List<ISchemaItem> SchemaItem { get; set; }
        public List<IExpander> Expander { get; set; }
        public List<string> InputList { get ; set; }

        public void ExecutePlugin()
        {
            Initializer(SchemaItem, Expander);
            MainFunction(12);
            Output = ExpandedText.ToString();
        }
    }
}