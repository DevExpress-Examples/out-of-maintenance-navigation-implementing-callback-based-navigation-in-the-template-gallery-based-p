<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552987/21.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T357692)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DXWebApp/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebAppVB/Controllers/HomeController.vb))
* [CallbackPanelPartial.cshtml](./CS/DXWebApp/Views/Home/CallbackPanelPartial.cshtml)
* [Index.cshtml](./CS/DXWebApp/Views/Home/Index.cshtml)
* [View1Partial.cshtml](./CS/DXWebApp/Views/Home/View1Partial.cshtml)
* [View2Partial.cshtml](./CS/DXWebApp/Views/Home/View2Partial.cshtml)
* [View3Partial.cshtml](./CS/DXWebApp/Views/Home/View3Partial.cshtml)
* [View4Partial.cshtml](./CS/DXWebApp/Views/Home/View4Partial.cshtml)
* **[_rootLayout.cshtml](./CS/DXWebApp/Views/Shared/_rootLayout.cshtml)**
* [ContentLeftPartialView.cshtml](./CS/DXWebApp/Views/Shared/ContentLeftPartialView.cshtml)
<!-- default file list end -->
# Navigation - Implementing callback-based navigation in the Template Gallery-based project
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t357692)**
<!-- run online end -->


<strong>Problem:</strong><br>
<p>I created a new MVC application by using the ASP.NET MVC Web Application template from the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument11613">Template Gallery</a> (see also: <a href="https://documentation.devexpress.com/#AspNet/CustomDocument11614">Project Wizard</a>). After that, I added several custom partial views and want to load them dynamically when an end-user clicks a specific item of the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument9004">NavBar</a> extension in the ContentLeftPartialView.cshtml partial view. What should I do?</p>
<br><strong>Solution:</strong><br>Here are the most straightforward approaches to solving this problem:<br><br>1) Load the required partial views via  the <strong>jQuery.ajax</strong> function by using the approach illustrated in the <a href="https://www.devexpress.com/Support/Center/p/E4063">E4063 - How to use the jQuery.ajax function with DevExpress MVC Extensions</a> code example. <br><br>2) Or, use our <a href="https://documentation.devexpress.com/#AspNet/CustomDocument9000">CallbackPanel</a> extension and the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMVCScriptsMVCxClientCallbackPanel_PerformCallbacktopic(2wupCg)">MVCxClientCallbackPanel.PerformCallback(Object)</a> method.<br><br>In both scenarios, you need to handle the client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientNavBar_ItemClicktopic">ASPxClientNavBar.ItemClick</a> event and initiate a parametrized callback (ajax or CallbackPanel-specific) to the appropriate controller's action method on the server side and get the required partial view.<br><br>Note that if you are working with regular (full) views instead of partial views, follow the approaches described in the <a href="https://www.devexpress.com/Support/Center/p/KA18732">KA18732 - How to open external Page / View in a Splitter Pane</a> KB article and examples linked to this article.<br><br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/KA18923">KA18923 - The SetContent method - How to define a content using different syntax constructions</a><br><a href="https://www.devexpress.com/Support/Center/p/E5019">Menu - How to load a content using callbacks on a menu item click based on the DevExpress Project template</a>

<br/>


