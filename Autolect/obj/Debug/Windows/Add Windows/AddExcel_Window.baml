   M S B A M L   `   `   `  ����C  ?Autolect, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AutolectAutolect  5   	       Autolect.AddExcel_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Autolect     5   	   -   5          �Name$  window��5   	    � Title$ AddExcel_Window��6    � WindowStartupLocation$ CenterScreen=�61      WindowsStyle#��[  6V   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5         Autolect.WindowHeader     Title$% Ajouter depuis un fichier Excel��6!   �� 5      $��Excel infos :��6   
�������$��16(�6A   $��8q�6O   .��5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6!   $��5q�6:   .+�5      �� $��
Fichier : ��6    
�������65   �� 5      -   5         ��Name$ TB_FilePath��5   "    �� 
IsReadOnly . $��12(�6I   $	��300��6W   $��Center=�6c   $��Center=�6~   �� 5      -   5         ��Name$ BT_ChooseFile��5   !   $	��...��68   $	��2,0q�6F     SecondaryButtonStyle#��[ 6S   6�   5      �� 5      $ 
Horizontal=�6!   $��5q�6:   .+�5      �� $��Nom de la feuil : ��6    
�������6=   �� 5      -   5        $ TB_SheetName��5   "   $��Feuil1��68   $	��200��6F   $��Center=�6R   5      �� 5      $ 
Horizontal=�6!   $��5q�6:   .+�5      �� $ Vertical=�6%   $��3q�6<   .+�5      �� $%��Cellule de début de la liste :��6$   
�������6M   �� 5      -   5        $ TB_StartCell��5   &   $��A1��6<   $
��20,0q�6F   $��Center=�6T   5      �� 5       $ Vertical=�6%   $��3q�6<   .+�5!      �� $"��Cellule de fin de la liste :��6$   
�������6K   �� 5"      -   5        $ 
TB_EndCell��5"   &   $	��A20��6:   $
��20,0q�6E   $��Center=�6S   5#      5%      5'      5(      �� 5*      -   5        $ BT_Add��5*      $��Valider��6%     MainButtonStyle#��[ 67   $��80, 20q�6`   6p   5+      5,      5-      