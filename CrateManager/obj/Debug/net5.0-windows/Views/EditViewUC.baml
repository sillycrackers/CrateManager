   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5       CrateManager#   CrateManager.Views.EditViewUC   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors  5      [
dropShadowJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5        � 	Resources  5         
EditButton �� 
TargetType �� Property �� Value  VarelaRound  	BoolToVis��%�   &	        7  &	 �     �� 5   
   " ��6#   .�5      ��  � ��$ 16(�6)   �� 5       � ��$ 4q�6(   �� 5       � ��8   6+   5      �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   $��Stretch=�6"   $��
50,10,0,10q�6@    �� Orientation$ 
Horizontal=�6T   .+�5       �� .+�5#      �� $ 
Horizontal=�6   $��0,0,30,0q�66   .+�5%      �� $��20��6    $��20��6+   $��	15,2,15,0q�67   $��Center=�6J   ��5&      L� 5'       L� Drawing 5(   "   I� 5)   &   ��5+   .   �  � Brush �	#00FFFFFF � Geometry+ �� $�  $� �     $� �        � $�     6P   � 5,   .    �	#FF388934� �p��[  ��6*�Ѭ�[ ��[ � @U0*�3?��[ � @U0*�3?��� Ѭ�[ ��� Ѭ�[ 8#� Ѭ�� 8#� Ѭ�� ��� �,%� ��� �,%� ��[ Ѭ�� ��[ Q���  ��6*�6P   � 5-   .    �	#FF388934s ����� @T� �@T� @T� �@T� ��� ���j ��� ���j @T� �@B @T� �@B ��j ���j ��j ���j @B �@T� @B �@T� ��j ���� ��j 6P   5/   '   51      53      �� 55        TextBlockOnDark#��[ 6    $��Add New Crate��6I   $��40(�56       $��Center=�6.   $��Center=�6K   $��	0,10,0,10q�57       59      5   /Microsoft.Windows.Themes.SystemDropShadowChrome  5;      	   CornerRadius$	 10��64   $��Center=�6F   ._�5<      ��   	CrateBlue#��[ 6   
 �� Padding$
 30,15,30,15q�6E   $��Center=�5=      $
��Auto��6:    �� CornerRadius$ 10��6H   $��Center=�5>       K� ZIndex$ 1��68   ._�5B      �� $��Center=�6%   $��Center=�6B   $	��175��5C   %   .+�5E   "   �� $��Crate Name:��6,     TextBlockOnCrate#��[ 6?   $��10q�5F   -   $��16(�69   $
��Left=�6G   $	��150��5G   ,   �� 5J   "   -   5         ��Name$ TextBoxName��5J   *    �� 	MaxLength$ 15��6?   $��
10,0,10,10q�5K   U   ��6*   �� *Name+ �� Mode$ OneWayToSource=�6U   �� 5M   "   $��	Category:��6,   #��[ 6=   $��10q�5N   -   $��16(�6:   $
��Left=�6H   �� 5O   "   -   5         ��Name$ ComboBoxCategory��5O   +   $��
10,0,10,10q�5P   +   ��6?   �� *
Categories+ �� SelectedValue 5Q   +   �� *
Category+$ OneWayToSource=��� 5S   "   $��
Key Items:��6,   #��[ 6>   $��10q�5T   -   $��16(�6:   $
��Left=�6H   �� 5W   "   -   5        $ TextBoxKeyItems��5W   *   $��
10,0,10,10q�5X   *   $	��100��6>    �� TextWrapping$
 Wrap=�6K   $ 68��6_   ��5W   C   �� *
KeyItems+$ OneWayToSource=�5X   _   �� 5Z      -   5        #��[  5Z   %   $��Create��5[   %   $��10q�66   $��Center=�5\   %   $	��100��6B   ��5[   B   �� *AddNewCrateCommand+5\   b   �� 5]      -   5         ��Name$ TextBlockWarning��5]   (   $��Missing Information Above��6B   
���  ��$��12(�6t   $��Center=�5^   (   $y�Hidden=�6E   5`      5b      5c      5d      �� 5h      $��10q�6   $��1��6%   $	��175��62   $��Center=�6>   .+�5i      �� $��Add New Category:��6   #��[ 66   $��10q�5j      $��16(�6)   $��Center=�67   $	��150��5k      �� 5m      -   5        $ AddCategoryTextBox��5m      $��10q�66   $��Center=�6B   $	��100��5n      $ 20��6&   �� 5o      -   5         ��Name$ ButtonCreate��5p      #��[  5o      $	��Add��5p   /   $��10q�6=   $��Center=�5r      $	��100��66   ��5p   I   �� *AddCategoryCommand+��5q      ��  �� ElementName$ AddCategoryTextBox�� �� Path$
 Text�5r   6   5t      �� 5x      .+�5y      �� #��[ 6   $��Edit Existing Crate��6E   $��0��5z      $��0��6%   $��5��62   $��40(�6F   $��Center=�5{      $��Center=�62   $��	0,10,0,10q�6M   �� 5}      $��Select Crate:��6   #��[ 61   $��10q�5~      $��16(�6)   $��Center=�67   �� 5      -   5        $ ComboBoxSelectCrate��5      $��
60,0,60,20q�5�   +    �� DisplayMemberPath$
 Name��5�   +   ��5�   ?   �� *&$MainViewModel.CratesViewModel.Crates+$ TwoWay=� �� SelectedItem 5�   +   �� *SelectedCrate+$ OneWayToSource=�*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5�      +  %Microsoft.Xaml.Behaviors.EventTrigger  5�         	EventName$ SelectionChanged��61   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5�      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6<   �� *CrateSelectedChangedCommand+5�      5�        5�      $	 10��64   $��Center=�6F   y�5�   4   �� $ ItemSelected� �� 	Converter# [ ._�5�      �� #��[ 6   $
 
30,15,30,0q�6E   $��Center=�5�      $
��Auto��6:   $ 10��6H   $��Center=�5�      $ 1��68   ._�5�      �� $��Center=�6%   $��Center=�6B   $	��175��5�   %   .+�5�      �� $��Crate Name:��6(   #��[ 6;   $��10q�5�   -   $��16(�69   $
��Left=�6G   $	��150��5�   ,   �� 5�      -	   5        $ TextBoxNameEdit��5�   &   $ 15��6?   $��	10,0,10,5q�5�   P   ��6*   �� *	NewName+$ TwoWay=�6P   �� 5�      $��	Category:��6(   #��[ 69   $��
10,5,10,10q�5�   -   $��16(�6B   $
��Left=�6P   �� 5�      -
   5        $ ComboBoxCategoryEdit��5�   '   $��
10,0,10,10q�5�   +   ��6?   �� *
Categories+ 5�   +   �� *NewCategory+$ TwoWay=��� 5�      $��
Key Items:��6(   #��[ 6:   $��10q�5�   -   $��16(�6:   $
��Left=�6H   �� 5�      -   5        $ TextBoxKeyItemsEdit��5�   &   $��
10,0,10,00q�5�   *   $	��100��6>   $
 Wrap=�6K   $ 68��6_   ��5�   C   �� *NewKeyItems+$ TwoWay=�5�   _   �� 5�      -   5        #��[  5�   %   $��Update��5�   %   $��10,20,10,10q�66   $��Center=�5�   %   $	��100��6B   ��5�   K   �� *UpdateCrateCommand+5�   n   �� 5�      -   5        $ TextBlockWarningEdit��5�   (   $��Missing Information Above��6F   
���  ��$��12(�6x   $��Center=�5�   (   $y�Hidden=�6E   $��0,0,0,10q�6Y   5�      5�      5�      5�      5�      5�      5�      