   M S B A M L   `   `   `  ����R  NPrivèValidaDownloadApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PrivèValidaDownloadAppPrivèValidaDownloadApp  5   	   (    "PrivèValidaDownloadApp.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:PrivèValidaDownloadApp     5   	     � Title$   ��5   	   $	��691��6   $
��1200��6    � 
ResizeMode$ NoResize=�6,    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundButtonStyle �� 
TargetType	 �� 
TargetType
 ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  FocusVisual1  Button.Static.Background1  Button.Static.Border1   Button.MouseOver.Background1  Button.MouseOver.Border1  Button.Pressed.Background1  Button.Pressed.Border1  Button.Disabled.Background1  Button.Disabled.Border1  Button.Disabled.Foreground1  RoundButtonStyle1  FocusVisual2  Button.Static.Background2  Button.Static.Border2   Button.MouseOver.Background2  Button.MouseOver.Border2  Button.Pressed.Background2  Button.Pressed.Border2  Button.Disabled.Background2  Button.Disabled.Border2  Button.Disabled.Foreground2   RoundButtonStyle2��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	 �    &	 �    &	 �    &	     &	 =    &	 `    &	 �    &	 �    &	 �    &	 �    7  7  7  7  7  7  7  7  7  7  &	 �    &	 �    &	 �    &	 �    &	     &	 ;    &	 ^    &	 �    &	 �    &	 �    &	  �    7  7  7  7  7  7  7  7  7  7  �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6)   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 0q�6(   �� 5%       � �� 5&      �� 5'      "	 ��6&   .R�5(      �� $
 border��6!   $ 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      �� 5A   
   .�5B      ��  � �� 5C      �� 5D      .R�5E      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5F      5H      5I      �� 5J   
   $ 	#FFDDDDDD��6<   �� 5K   
   $ 	#FF707070��68   �� 5L   
   $ 	#FFBEE6FD��6?   �� 5M   
   $ 	#FF3C7FB1��6;   �� 5N   
   $ 	#FFC4E5F6��6=   �� 5O   
   $ 	#FF2C628B��69   �� 5P   
   $ 	#FFF4F4F4��6>   �� 5Q   
   $ 	#FFADB2B5��6:   �� 5R   
   $ 	#FF838383��6>   �� 5S   
   " ��6*   .�5T      ��  �@�FocusVisualStyle8   61   �� 5U       � ��8  6+   �� 5V       � ��8  6,   �� 5W       � ��# � ��6+   �� 5X       � ��$ 1q�60   �� 5Y       � ��$ Center=�6;   �� 5Z       � ��$ Center=�69   �� 5[       � ��$ 0q�6(   �� 5\       � �� 5]      �� 5^      "	 ��6&   .R�5_      �� $
 border��6!   $ 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5`      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5a       5b      P� 5c       �@��IsDefaulted$
 true��6=   . �5d   "   �� $ border��6@   # � ��6T    � ��5e      P� 5f       �@J�IsMouseOver$
 true��6=   . �5g   "   �� $ border��6?   8   � ��6S   �� 5h   "   $ border��6@   8   � ��6T   5i      P� 5j       � ��$
 true��6;   . �5k   "   �� $ border��6?   8   � ��6S   �� 5l   "   $ border��6@   8   � ��6T   5m      P� 5n       � {�$ false��6;   . �5o   "   �� $ border��6?   8   � ��6S   �� 5p   "   $ border��6@   8   � ��6T   �� 5q   "   $ contentPresenter��6K   8 	  � ��6i   5r      5t      5v      5w      �� 5x   
   .�5y      ��  � �� 5z      �� 5{      .R�5|      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5}      5      5�      �� 5�   
   $ 	#FFDDDDDD��6<   �� 5�   
   $ 	#FF707070��68   �� 5�   
   $ 	#FFBEE6FD��6?   �� 5�   
   $ 	#FF3C7FB1��6;   �� 5�   
   $ 	#FFC4E5F6��6=   �� 5�   
   $ 	#FF2C628B��69   �� 5�   
   $ 	#FFF4F4F4��6>   �� 5�   
   $ 	#FFADB2B5��6:   �� 5�   
   $ 	#FF838383��6>   �� 5�   
   " ��6*   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 0q�6(   �� 5�       � �� 5�      �� 5�      "	 ��6&   .R�5�      �� $
 border��6!   $ 20��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5�      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5�       5�      P� 5�       �@��IsDefaulted$
 true��6=   . �5�   "   �� $ border��6@   # � ��6T    � ��5�      P� 5�       �@J�IsMouseOver$
 true��6=   . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   5�      P� 5�       � ��$
 true��6;   . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   5�      P� 5�       � {�$ false��6;   . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   �� 5�   "   $ contentPresenter��6K   8 	  � ��6i   5�      5�      5�      5�      5�      ��5�      �� 5�   
    �� ImageSource$ 	/back.png��6   .��5�      � .+�5�   
   �� -   5         ��Name$ 	LblTitolo��5�      $��Safety��6#   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6b   
�������$��36(�6�   $��Cooper Black)�6�   �� 5�   
   -   5         ��Name$ 	BtnAvanti��5�   <   #��� 
 6   $��Avanti��6O   $
��Left=�6`   $��1013,569,0,0q�6{   $	��Top=�6�   ���	#FF00A2E8
����������	#FF00A2E8$��Cooper Black)�6�   $��30(�6  $��2,2,2,2q�6  $��10,10,10,10q�6-  6C  �� 5�   
   -   5        $ BtnIndietro��5�   =   #���  6   $��Indietro��6R   $
��Left=�6e   $��
22,569,0,0q�6�   $	��Top=�6�   
����������	#FF00A2E8���	#FF00A2E8$��Cooper Black)�6�   $��30(�6  $��2,2,2,2q�6  $��10,10,10,10q�60  ${�False��6F  6X  � 5�   
   -   5         �Name$ 
pbProgress��5�       � Minimum$ 0Q�6*    � Maximum$	 100Q�66    � Value$ 0Q�6D   $��Center=�6N   $��15��6k   $��	0,591,0,0q�6w   $	��Top=�6�   $	��768��6�   $��2,2,2,2q�6�   ���	#FF00A8F3
�������6�   �� 5�   
   -   5         ��Name$ TbRisultato��5�      $
��Left=�6)   $��940,135,0,0q�6D   $�� ��6Y   $
��Wrap=�6a   $	��Top=�6u   
�������$��Cooper Black)�6�   $��55(�6�   $	��230��6�   $	��306��6�   �� 5�   
   -   5        $ 
LblImporta��5�   (   $
��Wrap=�6   $
��Left=�6=   $��
42,186,0,0q�6X   $	��Top=�6l   
�������$��Cooper Black)�6�   $��36(�6�   $	��817��6�   $"��Seleziona il tuo file (.iso)��6�    �� TextAlignment$ Center=�6�   $��90��6  �� 5�   
   -   5        $ 
BtnImporta��5�   R   $y�Visible=�6   #���   6&   $��	Seleziona��6f   $
��Left=�6z   $��352,281,0,0q�6�   $	��Top=�6�   
�������
����������	#FF00A8F3$��Cooper Black)�6   $��36(�6  $��2,2,2,2q�6(  $��10,10,10,10q�6B  6X  �� 5�   
   -   5        $ lblFile��5�      $��Nessun file selezionato��6!   $
��Left=�6C   $��
23,347,0,0q�6^   $	��Top=�6r   $��Cooper Black)�6�   
�������$��16(�6�   $��Italic$�6�   $��Center=�6�   $	��854��6  ��6�   Z� 6  �� 5�   
   -	   5        $ 	lblIndice��5�      $	��1/4��6#   $
��Left=�61   $��
804,17,0,0q�6L   $	��Top=�6`   
�������$��Cooper Black)�6�   $��24(�6�    J� RenderTransformOrigin$ 1.591,1.216&�6�   $��82��6�   ���	#FF00A8F3$��Center=�6�   �� 5�   
   -
   5         ��Name$ 	txtFinger��5�      $y�Hidden=�6%   $
��Left=�69   $��357,289,0,0q�6T   $�� ��6i    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��186��6�   $��Cooper Black)�6�   $��22(�6�   
�������
����������	#FF00A8F3$��2,2,2,2q�6  $��10,10,10,10q�6)   �� SelectionBrush �	#FF00A8F36?  	� 5�   
   -   5         	�Name$
 RbSI��5�      $y�Hidden=�6$   $��SI��68   $
��Left=�6E   $��281,297,0,0q�6`   $	��Top=�6u   
�������
�������
�������$��Cooper Black)�6�   $��30(�6�   $��Center=�6�   $
��Left=�6  63  	� 5�   
   -   5        $
 RbNO��5�      $y�Hidden=�6$   $��NO��68   $��Center=�6E   $��	0,297,0,0q�6b   $	��Top=�6u   
�������
�������
�������$��Cooper Black)�6�   $��30(�6�   $��Center=�6�   $
��Left=�6  63  5�      5�      