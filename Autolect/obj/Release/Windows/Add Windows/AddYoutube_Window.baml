   M S B A M L   `   `   `  ���� C  ?Autolect, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AutolectAutolect       Autolect.AddYoutube_Window   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Autolect     -     �Name$  window��   WindowsStyle#��[   � WindowStartupLocation$ CenterScreen=�.����  �� Orientation$ Vertical=�.+�   Autolect.WindowHeader     Title$ Commentaires YouTube���� $��Lien de la vidéo :��
�������$��5q�.���� $ 
Horizontal=�$��Center=�.+��� -    ��Name$ TB_VideoLink��$	��333��$��30�� �� TextWrapping$
 Wrap=�$�� ��$	��Top=��� -    ��Name$ BT_PastLink��$��30��$��30��
���������Z� .���� $7��1pack://application:,,,/Resources/Images/Paste.png���� $��	Options :��
�������$��5q�.���� $ Vertical=�$��5q�.+�	� -    	�Name$ 	RB_AddAll��$>��8Ajouter tout les participants qui ont mit un commentaire�� d� 	IsChecked$
 TrueY�
��������� $ 
Horizontal=�$��
0, 8, 0, 0q�.+�	� -   $ RB_AddBasedComments��$/��)Ajouter les participants qui ont écrit :��
��������� -   $ 
TB_Comment��$
��5, 0q�$
 Wrap=�$��Tapez du texte��$	��134���� $A��;Que faire si un participant a mit plusieurs commentaire ? :��
�������$��5q�.���� $ Vertical=�$��5q�.+�	� -   $ 
RB_JustOne��$!��Le compter qu'une seul fois��$��0,0,0,8q�$
 TrueY�
�������	� -   $ 	RB_Remove��$��Le supprimer de la liste��$��0,0,0,8q�
�������	� -	   $ 
RB_Nothing��$��Le compter plusieurs fois��$��0,0,0,0q�$	��Top=�
��������� -
   $ BT_Add��$��Ajouter��$��25, 8q�  MainButtonStyle#��[ 
�������
����������� 	 �� EndPoint$	 0.5,1&�
 �� 
StartPoint$
 0.5,0&�.���  � Color$ 	#FF9E2F2F�� � Offset$ 0Q�� $ 	#FF3A0909��$ 1Q�