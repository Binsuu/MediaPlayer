   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5   
   ? ;Quiz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Quiz.Pages
Quiz.Pages 5   	      Quiz.Pages.SwfPlayer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^shadowsJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5   
   *localclr-namespace:Quiz.Pages     5   	   
�������  � Title$  	SwfPlayer��5
   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Slider.xaml?�6%   %    5      .��5      � .+�5   
   5   /Microsoft.Windows.Themes.SystemDropShadowChrome  $��20,20,20,20q�6)      CornerRadius$ 15,15,15,15��6>   ._�5      ��  �� CornerRadius$ 15,15,15,15��6   
������� J� Opacity$ 1Q�6C   ._�5      � -   5        $��GridMain��5       � RowDefinitions 5      �� 5      $��40 �6(   �� 5      $��* �6(   �� 5      $��0 �6(   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6.   
 �� EndPoint$	
 0,1&�6?   ��5!   "   � � 5"   &    � Color$ #B82612��63    � Offset$	 0.0Q�6C   � 5#   &   $ #63180D��63   $	 1.0Q�6C   5$   #   5&      .+�5(      � $��0��6   .+�5)      � .+�5*      �� $��
Animiation��6$   $��Center=�69   
�������$��25(�6h   $��Center=�6v   �� 5+      -   5        $��total��5+   %   $��Bottom=�62   
�������$��12(�6a   $��Center=�6o   5,      5-      � 5.      -   5        $��grid1��5.      $��1��6(   50      �� 51      -   5        $��control��51   !   $��2��60   .+�52      � -   5        $
��ctrl��52      $��Stretch=�6+   $	��100��6I   $��Stretch=�6V    54      �� 55   "   $��0 �60   �� 56   "   $	��100 �60   .+�58      � $��0��6#   5;      � 5=      $��1��6#    � ColumnDefinitions 5>   "   �� 5?   &   $��10 �67   �� 5A   &   $��* �67   �� 5B   &   $��20 �67   �� 5C   &   $	��180 �67   �� 5D   &   $��80 �67   �� 5E   &   $��80 �67   �� 5F   &   $��80 �67   �� 5G   &   $	��180 �67   �� 5H   &   $��* �67   �� 5J   &   $��10 �67   .+�5P   "   � -   5        $��slider��5P   /   $��3��6=   $��	20,0,20,0q�6M   $��Center=�6`    � Value$	 500Q�6|   6�   �� 5Q   "   -   5        $��4��5Q   )   $��Right=�69   $��40��6U   $��40��6a      roundButton#���   6l   .��5R   &   �� $��3��60   
�������$��20(�6L   $��Webdings)�6Z   6r   5S   #   �� 5T   "   -   5        $��5��5T   )   $��70��6:   $��70��6F   #���   6R   $
��Bold"�6x   .��5U   &   �� $��;��60   
�������$��20(�6L   $��Webdings)�6Z   6r   5V   #   �� 5X   "   -	   5        $��6��5X   )   $
��Left=�69   $��40��6U   $��40��6b   #���   6n   $	��5,0q�6�   .��5Y   &   �� $��4��60   
�������$��20(�6L   $��Webdings)�6Z   6r   5Z   #   �� 5[   "   $��7��6)   ._�5\   &   � .+�5]   *   �� -
   5        $
��Left=�5]   1   $��10,0,0,0q�6L   #���   6^   $��20��6�   $��20��6�   6�   �� 5^   *   -   5        $��volumn��5^   2   $��6��6@   $��	40,0,40,0q�6P   $��Center=�6d   $	 500Q�6�   6�   5_   '   5`   #   5f      5g      5h      5v      5w      5x      5z      5|      