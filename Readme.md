<!-- default file list -->
*Files to look at*:

* [CustomObjects.cs](./CS/CustomObjectsBinding/CustomObjects.cs) (VB: [CustomObjects.vb](./VB/CustomObjectsBinding/CustomObjects.vb))
* [Form1.cs](./CS/CustomObjectsBinding/Form1.cs) (VB: [Form1.vb](./VB/CustomObjectsBinding/Form1.vb))
<!-- default file list end -->
# How to bind the SchedulerControl to a collection of custom objects


<p>This example illustrates how you can bind the <strong>XtraScheduler</strong> to a collection of custom  business objects. To accomplish this task, you should have two collections - one for appointments, another for resources. The appointment collection should implement the <strong>IBindingList</strong> interface. You can implement this interface manually in your custom collection, but we recommend you use the <strong>S</strong><strong>ystem.ComponentModel.BindingList<T></strong> collection.<br />
Additionally, your business object should have properties suitable for mapping to the corresponding properties of XtraScheduler's appointments and resources.</p>

<br/>


