# how-to-maintain-the-scroll-position-when-changing-source-at-runtime-in-.net-maui-listview

This example demonstrates about how to maintain the same scrolled position when updating the ItemsSource dynamically inn .NET MAUI ListView.

## Sample

```xaml
   <listView:SfListView x:Name="listView"
                                 Grid.Row="1"
                                 CanMaintainScrollPosition="True"
                                 ItemSize="70"
                                 ItemsSource="{Binding ContactsInfo}">
                <listView:SfListView.ItemTemplate>
                    <DataTemplate>
                        <StackLayout>
                            <Grid x:Name="grid"
                                  RowSpacing="0"
                                  RowDefinitions="*,Auto">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="70" />
                                    <ColumnDefinition Width="*" />
                                </Grid.ColumnDefinitions>
                                <Image Source="{Binding ContactImage}"
                                       HeightRequest="50"
                                       WidthRequest="50"
                                       Margin="5"
                                       HorizontalOptions="CenterAndExpand"
                                       VerticalOptions="CenterAndExpand" />
                                <Grid Grid.Column="1"
                                      RowSpacing="1"
                                      Grid.Row="0"
                                      Padding="10,0,0,0"
                                      VerticalOptions="Center">
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="*" />
                                        <RowDefinition Height="Auto" />
                                    </Grid.RowDefinitions>
                                    <Label Text="{Binding ContactName}"
                                           VerticalOptions="CenterAndExpand" />
                                    <Label Grid.Row="1"
                                           Text="{Binding ContactNumber}"
                                           VerticalOptions="StartAndExpand" />
                                </Grid>
                            </Grid>
                            <BoxView HeightRequest="1"
                                     BackgroundColor="#EEEEEE"
                                     Grid.Row="1"
                                     VerticalOptions="EndAndExpand" />
                        </StackLayout>
                    </DataTemplate>
                </listView:SfListView.ItemTemplate>
            </listView:SfListView>
```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
