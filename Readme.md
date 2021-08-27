<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633828/11.2.14%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E750)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomObjects.cs](./CS/CustomObjectsBinding/CustomObjects.cs) (VB: [CustomObjects.vb](./VB/CustomObjectsBinding/CustomObjects.vb))
* [Form1.cs](./CS/CustomObjectsBinding/Form1.cs) (VB: [Form1.vb](./VB/CustomObjectsBinding/Form1.vb))
<!-- default file list end -->
# How to bind the SchedulerControl to a collection of custom objects


<p>This example illustrates how you can bind the <strong>XtraScheduler</strong> to a collection of custom  business objects. To accomplish this task, you should have two collections - one for appointments, another for resources. The appointment collection should implement the <strong>IBindingList</strong> interface. You can implement this interface manually in your custom collection, but we recommend you use the <strong>S</strong><strong>ystem.ComponentModel.BindingList<T></strong> collection.<br />
Additionally, your business object should have properties suitable for mapping to the corresponding properties of XtraScheduler's appointments and resources.</p>

<br/>


