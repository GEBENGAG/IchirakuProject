   M S B A M L   `   `   `  ����I  EIshirakuCooker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:IshirakuCookerIshirakuCooker  5   	       IshirakuCooker.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:IshirakuCooker     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$
 None=�6K    � WindowState$ 	Maximized=�6^   ���#212030.��5	      �  � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      6   .+�5   
   �� -   5         ��Name$ 
updateGrid��5      $��Обновить��6%   $��50��6Q   $	��100��6]   6k   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
OrdersGrid��5   �   $��1��6   ���#212030   CanUserAddRows .     CanUserReorderColumns .     AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6&      Header$ 
Заказ��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *ИдЗаказа+6^     5      $
 * 6%   $ Статус Заказа��6/    6F   �� *+)СтатусЗаказа.Название+6r      RowDetailsTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $	��100��6$   $��	50,0,50,0q�61   ��6D   �� *Блюда.Название+�� 5      $��Количество:��6$   69   �� 5      $	��100��6$   $��	50,0,50,0q�61   ��6D   �� * ОбщееКоличество+�� 5      $ OrderStatusChange��6!   -   5        $��Приготовлено��5   <   
��� � �
�������$��50��6y   $��14(�6�   5       5!      5%      5'      5)      5*      