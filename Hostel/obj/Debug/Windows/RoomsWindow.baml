   M S B A M L   `   `   `  ����A  =Hostel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Hostel.WindowsHostel.Windows  5   	        Hostel.Windows.RoomsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Hostel.Windows     5   	   -   5          � Title$  Номерной фонд��5   	   $	��450��6   $	��800��6,   $	��425��68   $	��775��6H   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �  5      �� 5      $
��auto �6#   �� 5      .+�5      �� $��
Поиск��6   $��24(�6$   �� 5      -   5         ��Name$ SearchTextBox��5      $��1��6-   $��5q�6=   6H   5      �� 5    
   -   5         ��Name$ RoomListView��5        $��1��6    �� SelectionMode$ Single=�66   6M   �� 5!   
   -   5         ��Name$ NoItemslabel��5!   q   $��1��6   $��Center=�6   $��Center=�6:   $&�� Ничего не найдено��6U   $y�	Collapsed=�5"       K� ZIndex$ 1��6'   $��32(�68   � 5$   
   $��2��6    5%      �� 5&      �� 5'      �� 5(      �� 5)      .+�5+      �� -   5         ��Name$ GoToOrdersButton��5+      $��Мои заказы��6/   $��5q�6D   $y�	Collapsed=�6n   5,      � 50   
   $��1��6   $��3��6    51      �� 52      $
��auto �6    �� 53      �� 54      $
��auto �6    �� 55      .+�58      �� $��Сортировка��6   $��16(�6)   �� 59      -   5        $ SortingListView��59      $��1��60   $ Single=�6=   6T   �� 5;      $��2��6   $��Фильтрация��6!   $��16(�66   �� 5<      -   5        $ FilterListView��5<      $��3��6/   $ Single=�6<   6S   5=      5>      5?      