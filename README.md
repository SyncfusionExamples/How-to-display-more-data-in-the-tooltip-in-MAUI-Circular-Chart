# How to display more data in the tooltip in MAUI Circular Chart

The [.NET MAUI SfCircularChart](https://www.syncfusion.com/maui-controls/maui-circular-charts) allows you to display additional data in the tooltip by customizing the tooltip content through the [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) property. This enables you to present more detailed information in the tooltip, enhancing the user experience when interacting with chart segments.

**Step 1: Define the DataTemplate for the Tooltip**

The [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) property is used to specify a custom template for the tooltip. In this case, the TooltipTemplate displays more data, such as the category name, amount, and percentage. By default, it displays the corresponding Y-axis value of the segment.

The binding context for [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) is [TooltipInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TooltipInfo.html), which provides the necessary data for the labels.

The following code demonstrates how to define a DataTemplate for the tooltip:

**[XAML]**
```
<chart:SfCircularChart>

    <chart:SfCircularChart.Resources>
        <DataTemplate x:Key="tooltipTemplate">

            <StackLayout Padding="10" Orientation="Vertical" Spacing="10">
                <!-- Category and Amount -->
                <StackLayout Orientation="Horizontal" VerticalOptions="Center" HorizontalOptions="Center" Spacing="10">
                    <Label Text="{Binding Item.Category}" TextColor="White" VerticalTextAlignment="Center" HorizontalOptions="Start" FontAttributes="Bold" FontFamily="Helvetica" FontSize="16"/>
                    <Label Text="{Binding Item.Amount, StringFormat=':  {0}$'}" TextColor="White" VerticalTextAlignment="Center" HorizontalOptions="End" FontAttributes="Bold" FontFamily="Helvetica" FontSize="16"/>
                </StackLayout>

                <!-- Separator -->
                <BoxView HeightRequest="1" BackgroundColor="#D3D3D3"/>

                <!-- Percentage -->
                <StackLayout Orientation="Horizontal" VerticalOptions="Center" HorizontalOptions="Center" Spacing="10">
                    <Label Text="Percentage" TextColor="White" VerticalTextAlignment="Center" HorizontalOptions="Start" FontAttributes="Bold" FontFamily="Helvetica" FontSize="14"/>
                    <Label Text="{Binding Item.Percentage, StringFormat=':  {0:F2}%'}" TextColor="White" VerticalTextAlignment="Center" HorizontalOptions="End" FontAttributes="Bold" FontFamily="Helvetica" FontSize="14"/>
                </StackLayout>

            </StackLayout>

        </DataTemplate>
    </chart:SfCircularChart.Resources>

    . . .
</chart:SfCircularChart>
```
**Step 2: Apply the Custom Tooltip Template**

Now, apply the custom tooltip template to the [PieSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html) by assigning it to the [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) property

**[XAML]**
```
    <chart:SfCircularChart>
        . . .
        <chart:PieSeries ItemsSource="{Binding Data}"
                         XBindingPath="Category" 
                         YBindingPath="Amount"
                         ShowDataLabels="True"
                         EnableTooltip="True"
                         LegendIcon="SeriesType"
                         TooltipTemplate="{StaticResource tooltipTemplate}"/>
    </chart:SfCircularChart>
```
By following these steps, you can display more data, such as category names, amounts, and percentages, in the chart's tooltip.

**Output**
 
 ![TooltipTemplate.gif](https://support.syncfusion.com/kb/agent/attachment/article/18806/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1MDQ1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.XFo2HjGuvVe5H72fFM38c8YWp333LjCT5SyMHoaxNlU)

**Troubleshooting**

Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on [How to display more data in the tooltip in MAUI Chart (SfCircularChart)]().