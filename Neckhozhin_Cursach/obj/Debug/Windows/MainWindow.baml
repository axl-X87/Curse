   M S B A M L   `   `   `  ����M  INeckhozhin_Cursach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Neckhozhin_CursachNeckhozhin_Cursach  5   	   #    Neckhozhin_Cursach.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Neckhozhin_Cursach     5   	     � 
ResizeMode$  NoResize=�5       � Title$ 
MainWindow��5   	   $	��720��6   $
��1280��6)   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $	��360 �6   �� 5      $	��915��6   $��* �6.   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��0.4* �6    �� 5      $��1* �6    �� 5      $
��0.4* �6    .+�5      �� $��0��6    �� Orientation$ Vertical=�6&   .+�5      �� $��/Resources/unknown.png��6   $	��100��69   �� 5      $��Perfomance Artist��6   $��Center=�65   $��40(�6R   $��	Underline{�6`   ��5      �� 5       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5      �  � Color$ 	#FF19F7B5��6+    � Offset$ 0.565Q�6=   � 5      $ 	#FF00BAF9��6+   $ 0.975Q�6=   5      5      5       � 5      -   5        	  �Name$	 PersonalFrame��5   !   $��1��6   
  � NavigationUIVisibility$
 Hidden=�68   5       � 5!   
   $��1��6    5"      �� 5#      $
��0.2* �6    �� 5$      $��1* �6    .+�5&      �� -   5         ��Name$ 	MenuPanel��5&   ?   $��0��6   $ 
Horizontal=�6&   .+�5'      �� -   5         ��Name$ Employer��5'   1   $��73��6   $	��163��6%   $��0��6Z   $��Сотрудники��6j      MenuButtonStyle#��[  6   �� 5(      -   5        $ 	Warehouse��5(   1   $��73��6   $	��163��6%   $��Склады��6\   #��[  6m   �� 5)      -   5        $ Order��5)   1   $��73��6   $	��163��6%   $��Заказы��6@   #��[  6e   �� 5*      -   5        $ CreateSupply��5*   1   $��73��6   $	��163��6%   $��Поставки��6b   #��[  6u   5+       � 5,      -   5        $	 	MainFrame��5,      $
��Left=�6'   $��1��6B   $
 Hidden=�6O   $	��580��6�   $	��900��6�   5-      5.      5/      