   M S B A M L   `   `   `  ����C  ?Autolect, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AutolectAutolect  5   	   !    Autolect.AddManually_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Autolect     5   	   -   5          �Name$  window��5   	    � Title$+ %Ajouter manuellement des participants��5   	    � WindowStartupLocation$ CenterScreen=�68      WindowsStyle#��[  6]   .��5
      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5         Autolect.WindowHeader     Title$ Ajouez des participants��6!   �� 5      $ Vertical=�6   $��Center=�60   $
��10,0q�6M   .+�5      � .+�5      �� $��un par ligne :��6   $
��Left=�65   $��14(�6P   $��Italic$�6^   
�������6q   �� 5      $ 
Horizontal=�6!   $��Right=�6:   .+�5      �� -   5         ��Name$ BT_OpenFile��5   !     SecondaryButtonStyle#��[ 66   $��Ouvrir��6d   $
��5, 2q�6u   $
��10,0q�6�   6�   �� 5      -   5        $ BT_SaveFile��5   !   $��Enregistrer��66   #��[ 6L   $
��5, 2q�6z   $
��10,0q�6�   6�   5      5      �� 5      -   5         ��Name$ TB_Participants��5      $	��189��63   $	��386��6@   $��Center=�6L    �� AcceptsReturn . $
��Auto=�6�    �� TextWrapping$
 Wrap=�6�   $��16(�6�   5      �� 5      -   5        $ BT_Add��5      $��Ajouter��6%   $��10q�67     MainButtonStyle#��[ 6C   6l   5      5      5      