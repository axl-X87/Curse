   M S B A M L   `   `   `  ����M  INeckhozhin_Cursach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Neckhozhin_Cursach.Windows.Frames!Neckhozhin_Cursach.Windows.Frames  5      =    7Neckhozhin_Cursach.Windows.Frames.ConstructorOrderFrame   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:Neckhozhin_Cursach.Windows.Frames     5        N� Title$  ConstructorOrderFrame��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� $)��#Выберите продукцию��6      TextBlTitleStyle#��[  6.   $
��Wrap=�6X   �� 5   
   $��1��6   $#��Выберите краску��6$   #��[  6;   $
��Wrap=�6e   �� 5   
   $��2��6   $4��.Выберите дату выполнения��6$   #��[  6D   $
��Wrap=�6n   �� 5   
   $��0��6   $��1��6%   $	��300��62   $	��Top=�6?   .+�5      �� -   5         ��Name$ ProductListCB��5      $��30��6[   $	��Top=�6g   $��20q�6   ��5      �� 5      .R�5      �� 
������ ��6$   �� *Name_P+6<   5      5       �� 5!      $��Количество��6     TextBlStyle#��[ 6*   $��10q�6O   �� 5"      -   5         ��Name$ AmountProductTB��5"      $��40 10q�6/   5#      �� 5$   
   $��1��6   $��1��6%   $	��300��62   $	��Top=�6?   .+�5%      �� -   5        $ PaintListCB��5%      $��30��6�   $	��Top=�6�   $��20q�6�   ��5&      �� 5'      .R�5(      �� 
������ ��6$   �� *Name_Color_P+6B   5)      5+      �� 5,      $��Пример цвета:��6   $��30 50 30 10q�6-   �� 5-      -   5         ��Name$ 
ShowColorB��5-      
������ $	��100��6B   $	��100��6O   5.      �� 5/   
   $��2��6   $��1��6%   $	��300��62   $	��Top=�6?   .+�50      (  "System.Windows.Controls.DatePicker  -   5          Name$ DateOrderFinishDP��50      51      � 52   
   $��2��6   $��3��6   .+�53      �� -   5         ��Name$ 	CreateBtn��53      $��Создать заказ��6@     SystemButtonStyle#��[ 6X   $��40q�6�   $	��300��6�   54      55      56      