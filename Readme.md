<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633828/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E750)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Scheduler - Bind to a collection of custom appointments

This example shows how to bind the WinForms Scheduler control to a collection of business objects (`CustomAppointment`). The example creates two collections - one for appointments, another for resources. The appointment collection implements `IBindingList` (we recommend that you use the `System.ComponentModel.BindingList<T>`).

> **Note**
>
> Custom objects must implement certain properties to map to the corresponding scheduler appointment and resource properties.


## Files to Review

* [Form1.cs](./CS/CustomObjectsBinding/Form1.cs) (VB: [Form1.vb](./VB/CustomObjectsBinding/Form1.vb))
* [CustomObjects.cs](./CS/CustomObjectsBinding/CustomObjects.cs) (VB: [CustomObjects.vb](./VB/CustomObjectsBinding/CustomObjects.vb))


## Documentation

* [Bind to Business Objects](https://docs.devexpress.com/WindowsForms/9606/controls-and-libraries/scheduler/data-binding/data-sources/business-objects)
* [Bind to Data - WinForms Scheduler](https://docs.devexpress.com/WindowsForms/8386/controls-and-libraries/scheduler/data-binding)
* [Mappings](https://docs.devexpress.com/WindowsForms/15468/controls-and-libraries/scheduler/data-binding/mappings)
* [Appointment Mappings](https://docs.devexpress.com/WindowsForms/17132/controls-and-libraries/scheduler/data-binding/mappings/appointment-mappings)
* [Resource Mappings](https://docs.devexpress.com/WindowsForms/17133/controls-and-libraries/scheduler/data-binding/mappings/resource-mappings)
