   M S B A M L   `   `   `  ����A  =Hostel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HostelHostel  5   	       Hostel.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Hostel     5   	     � Title$  Авторизация��5   	   $	��300��6   $	��550��6*   $	��325��5	   	   $	��325��6   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��1��6    5      �� 5      �� 5      .+�5      �� $��Авторизация��6   $��24(�6*   $��Center=�68   5      �� 5    
   $��Телефон:��6   $��1��6#   �� 5!   
   -   5         ��Name$ LoginTextBox��5!      $��1��6(   $��1��65   �� 5#   
   $��Пароль:��6   $��2��6"   G� 5$   
   -   5         G�Name$ PasswordPasswordBox��5$      $��2��63   $��1��6@   �� 5%   
   -   5        $ CheckPasswordTextBox��5%      $��2��60   $��1��6=   $y�Hidden=�6M   �� 5'   
   -   5         ��Name$ EnterButton��5'      $��
Войти��6&   $��3��66   $��1��6C   $��35��6S   6_   �� 5(   
   -   5        $ EnterAsGuest��5(      $"��Войти как гость��6'   $��4��6A   $��1��6N   6^   �� 5)   
   -   5        $ RegistrationButton��5)      $*��$Зарегистрироваться��6-   $��5��6J   $��1��6W   $��35��6g   6s   �� 5+   
   -   5         ��Name$ ShowPasswordCheckBox��5+      $��2��61   $��2��6A   $$��Показать пароль?��6N   6�   5,      5-      