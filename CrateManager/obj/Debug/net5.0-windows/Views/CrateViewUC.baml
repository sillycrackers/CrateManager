   M S B A M L   `   `   `  ����G  CCrateManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CrateManager.ViewsCrateManager.Views  5      $    CrateManager.Views.CrateViewUC   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:CrateManager.Views     5      .��5	      � $��10q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��30(�5      
�������$��10q�5      $��Medium"�6    ��5      �� *
Crate.Name+5       � 5   
   $��0��6     5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
MyDataGrid��5   ;   ���#2f2f2f$��0��5   ,   $
��Left=�5   O      MinColumnWidth$ 50Q�5         RowBackground �#2f2f2f$��0q�5         AutoGenerateColumns$ False��5         CanUserDeleteRows$
 True��63      CanUserResizeColumns$
 True��6L      CanUserAddRows$
 True��5      $
��1000��6-   $	��500��6:   $	��Top=�6G   $   HorizontalScrollBarVisibility$ Visible=�6_   "	   VerticalScrollBarVisibility$	 Visible=�5       ��5      �� *Crate.Items+
 J� InputBindings
 5"      �� 5#      
 �� Key$ C��6!    �� 	Modifiers$
 Ctrlf�6)    �� Command$
 Copy��6:      ColumnHeaderStyle 5(      �� 5)       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5*      ��  �� Property � �� �� Value �#CCCCCC67   �� 5+       � ��$ 1q�6<   �� 5,       � ��
 �   �68   �� 5-       � ��$ 8q�64   �� 5.       � ��$ DemiBold"�67   �� 5/       � ��$ 14(�65   �� 50       � ��$ 0q�63   �� 51       � ��   VarelaRound# [  67   53         Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     58      $ Part Number��6)   $	 150 6]    6>   �� *
PartNumber+6]     59      $ 	Quanitity��6)   $
 Auto 6Y    6<   �� *
Quantity+   ElementStyle 5:      �� 5;      " ��6$   .�5<   "   ��  � ��$ Center=�6H   5=      5?        5@      $ Description��6)   $
 Auto 6^    6>   �� *Description+6^      	CellStyle 5C      �� 5E      *  $System.Windows.Controls.DataGridCell"  6   .�5F      ��  � �� �#cccccc67   �� 5G       � ��$ 0q�6<   �� 5H       � ��$ 14(�65   �� 5I       � ��$ 2q�64   �� 5K       � �� 5L      �� 5M   "    �� 
TargetType"  62   .R�5N   &   ��  ��Name$ MyBorder��6-    �� Padding# z��6?   #��z��6c   #��z��5O   1   #��z��6e    J� SnapsToDevicePixels$
 True��5P   1   ._�5Q   *   �� # z 6;   5R   '    �� Triggers 5T   &   P� 5U   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �5V   .   ��  �� 
TargetName$ MyBorder��65    � �� �#7777776a   5W   +   5Z   #   5]      5^      5c      �� 5e        �� Orientation$  
Horizontal=�6   $��1��62   .+�5f      �� $��25��6   $��25��6'   $
��Left=�63   $��20,0,0,0q�6N   $��Center=�5g      ��5h      L� 5i      ! L� Drawing! 5j      I� 5k   "   ��5m   *   � " � Brush" �	#00FFFFFF# � Geometry+# �� $�  $� �     $� �        � $�     6L   � 5n   *   " �#AAAAAAG# ��*� h.� �xڱ �z� ��`TR'  @�L ��	@ �z� �x�M h.� ��`TR'  @p�g 6J   5p   #   5r      5t      �� 5u        TextBlockOnDark#��[ 6   $��Add New��6E   $��Center=�6T   $��5,0,0,0q�5v      $��14(�6-   5w      5x      5z      5|      