   M S B A M L   `   `   `  ����M  IWeatherForecastWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WeatherForecastWPFWeatherForecastWPF  5   	   #    WeatherForecastWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WeatherForecastWPF     5   	     � Title$  Weather Forecast��5   	   $	��400��5	   	   $	��700��5
   	   $��14(�5   	   .��5E      �  � RowDefinitions 5F   
   �� 5G      $
��0.2* �6   �� 5H      $
��0.3* �6   �� 5I      $��0.173* �6   �� 5J      $��0.173* �6   �� 5K      $��0.173* �6    � ColumnDefinitions 5N   
   �� 5O       z� SharedSizeGroup$ A��6   $��* �5P      .+�5S   
   �� -   5        $��	CityInput��5T      $	��200��5U      $��20��5V      $��0��5W      $��0��5X      $��Center=�5Y      $��Center=�5Z      $��Center=�5[      �� 5]   
   $��0��6   $��0��5^       J� IsHitTestVisible$ False��5_      $ ��Enter city and press enter��5`      $��Center=�5a      $
��Left=�5b      $��30,0,0,0q�5c      
���������5f      �� 5g       �� 
TargetType" ��6   .�5h      ��  �� Property � y� �� Value$ 	Collapsed=�5i       �� Triggers 5j      �� 5k      	 �� Binding	 6&   �� *Text+
 �� ElementName$
 	CityInput�� �� Value  5l   &   .a�5m      ��  � y�$ Visible=�5n   %   5o      5q      5s      �� 5u   
   -   5        $
��icon��5u      $��0��5v      $��1��5w      $��Center=�5x      $��Center=�5y      �� 5{   
   -   5        $��lblCityAndCountry��5{      $	��200��5|      $��28��5}      $��0��5~      $��2��5      $��Center=�5�      $��Center=�5�      $��Center=�5�      �� 5�   
   -   5        $��
lblWeather��5�      $	��200��5�      $��28��5�      $��0��5�      $��3��5�      $��Center=�5�      $��Center=�5�      $��Center=�5�      �� 5�   
   -   5        $��lblWeatherDescription��5�      $	��200��5�      $��28��5�      $��0��5�      $��4��5�      $��Center=�5�      $��Center=�5�      $��Center=�5�      5�      5�      