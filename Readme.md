# MVC DocumentViewer - How to create a custom CheckedComboBox parameter editor with the "Select All" functionality for a report


<p>This example demonstrates how to create a custom CheckedComboBox parameter editor with the "Select All" functionality for a report that is previewed in the MVC DocumentViewer extension. <br /><br />The report's built-in multi-select parameter functionality can use only the TokenBox editor. So, this approach will be helpful if you wish to use the CheckedComboBox editor with the "Select All" functionality.<br /><br />The approach demonstrated in the <a href="https://demos.devexpress.com/MVCxDataEditorsDemos/Editors/DropDownEdit"> Data Editors - Editor Types - Dropdown Edit</a> online demo is used to create a CheckedComboBox editor. The only difference is that the CheckedListWindowTemplate class that implements the ITemplate interface is used to set the DropdownWindowTemplate content.<br /><br /></p>
<p><strong>Important Note:</strong> The new <a href="https://documentation.devexpress.com/#aspnet/clsDevExpressWebMvcWebDocumentViewerExtensiontopic">WebDocumentViewer extension</a> uses the CheckedComboBox editor for multi-select parameters out of the box.</p>

<br/>


