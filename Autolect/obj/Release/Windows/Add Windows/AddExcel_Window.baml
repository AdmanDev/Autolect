   M S B A M L   `   `   `  ���� C  ?Autolect, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AutolectAutolect      Autolect.AddExcel_Window   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Autolect     -     �Name$  window�� � Title$ AddExcel_Window�� � WindowStartupLocation$ CenterScreen=�   WindowsStyle#��[  .��� .+���  �� Orientation$ Vertical=�.+�   Autolect.WindowHeader     Title$% Ajouter depuis un fichier Excel���� $��Excel infos :��
�������$��16(�$��8q�.���� $ Vertical=�.+��� $ 
Horizontal=�$��5q�.+��� $��
Fichier : ��
��������� -    ��Name$ TB_FilePath�� �� 
IsReadOnly . $��12(�$	��300��$��Center=�$��Center=��� -    ��Name$ BT_ChooseFile��$	��...��$	��2,0q�  SecondaryButtonStyle#��[ �� $ 
Horizontal=�$��5q�.+��� $��Nom de la feuil : ��
��������� -   $ TB_SheetName��$��Feuil1��$	��200��$��Center=��� $ 
Horizontal=�$��5q�.+��� $ Vertical=�$��3q�.+��� $%��Cellule de début de la liste :��
��������� -   $ TB_StartCell��$��A1��$
��20,0q�$��Center=��� $ Vertical=�$��3q�.+��� $"��Cellule de fin de la liste :��
��������� -   $ 
TB_EndCell��$	��A20��$
��20,0q�$��Center=��� -   $ BT_Add��$��Valider��  MainButtonStyle#��[ $��80, 20q�