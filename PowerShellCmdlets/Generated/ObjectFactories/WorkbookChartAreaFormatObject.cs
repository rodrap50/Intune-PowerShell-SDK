// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartAreaFormat&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartAreaFormat&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartAreaFormatObject", DefaultParameterSetName = @"microsoft.graph.workbookChartAreaFormat")]
    [ODataType("microsoft.graph.workbookChartAreaFormat")]
    public class New_WorkbookChartAreaFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAreaFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartFill")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAreaFormat", HelpMessage = @"The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.")]
        public System.Object fill { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;font&quot; property, of type &quot;microsoft.graph.workbookChartFont&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartAreaFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartFont")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartAreaFormat", HelpMessage = @"The &quot;font&quot; property, of type &quot;microsoft.graph.workbookChartFont&quot;.")]
        public System.Object font { get; set; }
    }
}