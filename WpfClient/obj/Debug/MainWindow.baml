   M S B A M L   `   `   `  ����D  @WpfClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfClient	WpfClient  5   	       WpfClient.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfClient     5   	     � Title$  Мой плейлист��5   	   $��385.167��6   $	��800��6/   $��Times New Roman)�6;   $��14(�6X    � WindowStartupLocation$ CenterScreen=�6f   .��5	      � $��0,0,0,6q�6    � ColumnDefinitions 5
   
   �� 5      $
��418* �6   �� 5      $
��375* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgMusics��5      $��10,10,10,43q�6%      AutoGenerateColumns .     
IsReadOnly . $��2��6h      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Исполнитель��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *AUTHOR+  5      $ Наименование��6%    6;   �� *NAME+  5      $ Альбом��6%    65   �� *ALBOM+  5      $ Год��6%    62   �� *YEAR+5      �� 5   
   -   5        	 ��Name$	 
btnRefresh��5      $
��Left=�6%   $��335,312,0,0q�6@   $	��Top=�6U   $��29��6m   $��Times New Roman)�6x   $��14(�6�   $
��Left=�6�   $��1��6�   .��5      �� 
 �� Orientation$
 
Horizontal=�6   $��24��62   .+�5      �� $��Images/refresh.png��6   $��25��64   $��25��6@   $��0,0,5,0q�6K   5      5      5      5      