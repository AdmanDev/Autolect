   M S B A M L   `   `   `  ����C  ?Autolect, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AutolectAutolect  5   	        Autolect.AddYoutube_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Autolect     5   	   -   5          �Name$  window��5   	      WindowsStyle#��[  5   	    � WindowStartupLocation$ CenterScreen=�6/   .��5
      ��  �� Orientation$ Vertical=�6   .+�5   
      Autolect.WindowHeader     Title$ Commentaires YouTube��6   �� 5   
   $��Lien de la vidéo :��6   
�������$��5q�6B   .��5      �� $ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5         ��Name$ TB_VideoLink��5      $	��333��60   $��30��6<    �� TextWrapping$
 Wrap=�6H   $�� ��6\   $	��Top=�6d   �� 5      -   5         ��Name$ BT_PastLink��5      $��30��6.   $��30��69   
���������6E   Z� .��5      �� $7��1pack://application:,,,/Resources/Images/Paste.png��6   5      5      5      �� 5   
   $��	Options :��6   
�������$��5q�69   .��5      �� $ Vertical=�6   $��5q�60   .+�5      	� -   5         	�Name$ 	RB_AddAll��5      $>��8Ajouter tout les participants qui ont mit un commentaire��61    d� 	IsChecked$
 TrueY�6t   
�������6�   �� 5      $ 
Horizontal=�6   $��
0, 8, 0, 0q�66   .+�5      	� -   5        $ RB_AddBasedComments��5   "   $/��)Ajouter les participants qui ont écrit :��6?   
�������6r   �� 5      -   5        $ 
TB_Comment��5      $
��5, 0q�62   $
 Wrap=�6@   $��Tapez du texte��6T   $	��134��6j   5      5      5      �� 5   
   $A��;Que faire si un participant a mit plusieurs commentaire ? :��6   
�������$��5q�6k   .��5      �� $ Vertical=�6   $��5q�60   .+�5       	� -   5        $ 
RB_JustOne��5       $!��Le compter qu'une seul fois��62   $��0,0,0,8q�6X   $
 TrueY�6i   
�������6z   	� 5!      -   5        $ 	RB_Remove��5!      $��Le supprimer de la liste��61   $��0,0,0,8q�6U   
�������6f   	� 5"      -	   5        $ 
RB_Nothing��5"      $��Le compter plusieurs fois��62   $��0,0,0,0q�6V   $	��Top=�6g   
�������6   5#      5$      �� 5%   
   -
   5        $ BT_Add��5%      $��Ajouter��6!   $��25, 8q�63     MainButtonStyle#��[ 6B   
�������
���������5&      �� 5'      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5(      �  � Color$ 	#FF9E2F2F��6#    � Offset$ 0Q�65   � 5)      $ 	#FF3A0909��6#   $ 1Q�65   5*      5,      5-      5.      