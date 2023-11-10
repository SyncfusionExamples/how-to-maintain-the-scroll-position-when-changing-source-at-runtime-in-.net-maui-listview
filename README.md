# how-to-maintain-the-scroll-position-when-changing-source-at-runtime-in-.net-maui-listview
This example demonstrates about how to maintain the same scrolled position when updating the ItemsSource dynamically inn .NET MAUI ListView (SfListView).

```
    <syncfusion:SfListView x:Name="listView" 
                       CanMaintainScrollPosition="True"/>
```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
