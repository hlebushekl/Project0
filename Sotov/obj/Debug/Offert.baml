   M S B A M L   `   `   `  ����@  <Sotov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SotovSotov  5   	       Sotov.Offert   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Sotov     5   	     � Title$  Offert��5      $	��650��6   $	��800��6$    � WindowStyle$
 None=�60    � AllowsTransparency .  � WindowStartupLocation$ CenterOwner=�6]   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��15 �6   �� 5      $	��14* �6   �� 5      $
��113* �6   .+�5   
   �� -   5         ��Name$
 Head��5      $��0��6   $��1��6/   $��2��6<    �� CornerRadius$ 0,0,0,10��6P   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 #D1913C��6#   � 5      $
 #FFD194��6#    � Offset$ 1Q�63   5      ._�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $
��Left=�6M   .+�5      �� $
��Left=�6   $��/Resurs/pngwing.com.png��63   �� 5      $��22(�6   $��33��6*   
��������� 6J   $�Сотовик��6N   6`   5      5      �� 5    
   -   5        $ Head2��5       $��1��6    $��1��60   $��1��6=   $ 0,0,10,0��6N   $��2��6f   $��	266,0,0,0q�6z   ��5!      �� 5"      $ 0.5,1&�6&   $	 0.5,0&�67   .��5#      � $
 #D1913C��6#   � 5$      $
 #FFD194��6#   $ 1Q�63   5%      ._�5'      �� -   5         ��Name$ Return��5'      $3��-Возврат к основному окну��6$   
�������$��Center=�6Z   $��45��6w   $��	0,10,0,15q�6�   $��18(�6�   ��6�   Z� 6�   5(      �� 5)   
   -   5        $ UpHead��5)      $��0��6!   $��0��61   $��3��6>   ��5*      �� 5+      $ 0.5,1&�6&   $	 0.5,0&�67   .��5,      � $
 #FFD194��6#   � 5-      $
 #D1913C��6#   $ 1Q�63   5.      50      �� 51   
   -   5        $
 Main��51      $��0��6   $��3��6/   $��3��6<   ._�52      �� .+�53      �� $��0,5,0,5q�6   $��24(�6)   $!��Имя получателя��67   $��Center=�6P   �� 54      -   5         ��Name$ CB_Model��54      $��0,5,0,5q�6,   $��24(�6=   $	��475��6K   
�������6W   �� 55      $��0,5,0,5q�6   $��24(�6)   $4��.Проверьте номер телефона��67   $��Center=�6Z   �� 56      -   5        $ TB_Name��56      $��0,5,0,5q�6+   $��24(�6<   $	��475��6J   
�������6V   �� 57      $��0,5,0,5q�6   $��24(�6)   $��
Заказ��67   $��Center=�6G   �� 58      -   5        $ TB_pzu��58      $��0,5,0,5q�6*   $��24(�6;   $	��475��6I   
�������6U   �� 59      $��0,5,0,5q�6   $��24(�6)   $#��Адресс доставки��67   $��Center=�6Q   �� 5:      -	   5         ��Name$ TB_Cost��5:      $��0,5,0,5q�6,   $��24(�6=   $	��475��6K   
�������6W   �� 5;      $��0,5,0,5q�6   $��24(�6)   $0��*Выберите способ оплаты��67   $��Center=�6X   �� 5<      $��38��6   $ 
Horizontal=�6)   $��Center=�6B   $��Center=�6_   $��0,0,0,10q�6z   .+�5=      �� $��При получении��6   $��24(�64   $��Center=�6B   $��Center=�6_   �� 5>      -
   5         ��Name$ cb_Nal��5>      $��Center=�6/   $��Bottom=�6L   
����������	#FF3CD2276�   �� 5?      $��Онлайн��6   $��24(�6.   $��15,0,0,0q�6<   �� 5@      -   5        $ 	cb_Online��5@      $��Center=�62   $��Bottom=�6O   
����������	#FF2ED8166�   5A      �� 5B      -   5         ��Name$ bt_Add��5B      $��0,5,0,5q�6)   $��24(�6:   $��66��6H   
�������$	��372��6j   $��Заказать��6v   
�������6�   5C      5D      5E      5F      