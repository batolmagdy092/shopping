   M S B A M L   `   `   `  ����H  Dloginshopping, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:loginshoppingloginshopping  5          loginshopping.manager   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:loginshopping     5        N� Title$  manager��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��37* �6   �� 5      $	��38* �6    � ColumnDefinitions 5   
   �� 5      $	��99* �6   �� 5      $
��101* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF0A607D��6    � Offset$ 1Q�61   5      .+�5   
   �� $��username��6   $
��Left=�6#   $��	64,57,0,0q�6>   $	��Top=�6Q   $	��144��6i   $��15(�6u   
�������6�   �� 5   
   $��
passwsword��6   $
��Left=�6%   $��64,0,0,0q�6@   $��Center=�6R   $	��144��6m   $��15(�6y   
�������6�   �� 5   
   -   5         ��Name$ txtname��5      $��1��6#   $
��Left=�63   $��	55,63,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��223��6�   $��24��6�   �� 5   
   -   5        $ txtpass��5      $��1��6#   $
��Left=�63   $��
55,111,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��223��6�   $��24��6�   �� 5   
   -   5        $��insert��5      $
��Left=�6"   $��	64,10,0,0q�6=   $��1��6P   $	��Top=�6]   $��96��6u   $��29��6�   6�   �� 5   
   -   5        $��update��5      $
��Left=�6"   $��
250,11,0,0q�6=   $��1��6Q   $	��Top=�6^   $��96��6v   $��29��6�   $��1��6�   6�   �� 5    
   -   5        $��delete��5       $
��Left=�6"   $��
352,11,0,0q�6=   $��1��6Q   $	��Top=�6^   $��96��6v   $��28��6�   $��2��6�   6�   � 5!   
   $��1��6   $��112,63,225,10q�6   $��2��63   .+�5"      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 datagrid��5"      5#      5%      5&      