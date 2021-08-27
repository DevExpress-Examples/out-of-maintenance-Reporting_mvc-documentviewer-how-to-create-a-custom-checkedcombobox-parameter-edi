<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596934/15.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T262163)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T262163/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T262163/Controllers/HomeController.vb))
* [ProductsReport.cs](./CS/T262163/Reports/ProductsReport.cs) (VB: [ProductsReport.vb](./VB/T262163/Reports/ProductsReport.vb))
* [CheckedListWindowTemplate.cs](./CS/T262163/Templates/CheckedListWindowTemplate.cs) (VB: [CheckedListWindowTemplate.vb](./VB/T262163/Templates/CheckedListWindowTemplate.vb))
* **[_DocumentViewerPartial.cshtml](./CS/T262163/Views/Home/_DocumentViewerPartial.cshtml)**
* [Index.cshtml](./CS/T262163/Views/Home/Index.cshtml)
<!-- default file list end -->
# MVC DocumentViewer - How to create a custom CheckedComboBox parameter editor with the "Select All" functionality for a report
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t262163/)**
<!-- run online end -->


<p>This example demonstrates how to create a custom CheckedComboBox parameter editor with the "Select All" functionality for a report that is previewed in the MVC DocumentViewer extension. <br /><br />The report's built-in multi-select parameter functionality can use only the TokenBox editor. So, this approach will be helpful if you wish to use the CheckedComboBox editor with the "Select All" functionality.<br /><br />The approach demonstrated in the <a href="https://demos.devexpress.com/MVCxDataEditorsDemos/Editors/DropDownEdit"> Data Editors - Editor Types - Dropdown Edit</a> online demo is used to create a CheckedComboBox editor. The only difference is that the CheckedListWindowTemplate class that implements the ITemplate interface is used to set the DropdownWindowTemplate content.<br /><br /></p>
<p><strong>Important Note:</strong> The <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.DocumentViewerExtension">Web Document Viewer extension</a> uses the CheckedComboBox editor for multi-select parameters out of the box.</p>

<br/>


