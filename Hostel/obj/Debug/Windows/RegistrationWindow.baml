   M S B A M L   `   `   `  ����A  =Hostel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Hostel.WindowsHostel.Windows  5   	   '    !Hostel.Windows.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Hostel.Windows     5   	     � Title$  Регистрация��5   	   $	��310��6   $	��450��6*   $	��295��5	   	   $	��425��6   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ RegistrationLabel��5      $��Регистрация��6+   $��1��6A   $��24(�6Q   $��Center=�6_   �� 5   
   $��1��6   $��Имя*��6   �� 5   
   -   5         ��Name$ NameTextBox��5   /   $��1��6   $��1��6    �� 	MaxLength$ 40��6t   �� 5   
   $��2��6   $��Фамилия��6   �� 5   
   -   5        $ SurnameTextBox��5   /   $��2��6   $��1��6   $ 40��6w   �� 5!   
   $��3��6   $��Отчество��6   �� 5"   
   -   5        $ PatronomycTextBox��5"   /   $��3��6   $��1��6   $ 40��6z   �� 5$   
   -   5        $ 
PhoneLabel��5$   0   $��4��6   $��Телефон*��6   60   �� 5%   
   -   5        $ PhoneTextBox��5%   /   $��4��6   $��1��6   $ 40��6E   6�   �� 5'   
   $��5��6   $��Пароль*��6   G� 5(   
   -   5         G�Name$ PasswordPasswodBox��5(   3   $��5��6   $��1��6#    G� 	MaxLength$ 40��6O   � 5*   
   $��6��6   $��2��6    5+      �� 5,      �� 5-      .+�5/      �� -   5         ��Name$ TryRegistration��5/      $*��$Зарегистрироваться��6.   6K   �� 50      $+��%* - Обязательные поля��6   $��1��64   51      52      53      