   M S B A M L   `   `   `  ����  SupportDownloader"    SupportDownloader.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$+  %Установщик программ��5   	   $	��400��6%   $	��625��62    � Icon$9 3/SupportDownloader;component/support_ico_64 (1).ico��6>    � 	Resources 5         ProgramListGroup �� Source �� Path �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName  ProgramDataTemplate �� ElementName � ColumnDefinitions	 �� Orientation
 d� 	IsChecked �� FallbackValue �� Command �� CommandParameter��%  &	        &	 j     �� 5   
    5      �� $ ProgramList� 5	        5
      $ TypeName��6+   5      �� 5   
   .R�5      � ��6   �� $ ActualWidth�$ temlateList�� 5      �� 5      $��60 �6'   �� 5      $��* �6'   .+�5      �� $��5q�6   
���   �$��1q�68   ._�5      �� $��UniformToFill=�6:   $��44��6S   $��44��6^   ��6   �� $
 Icon�6^   5      �� 5      $��1��6   $��5q�6-   .+�5      �� $	 
Horizontal=�6!   $
��Bold"�6:   .+�5      �� $��0,0,5,0q�6F   
 6#   �� $ Checked�6F   �� 5      ��6$   �� $
 Name�$
 Name��5      �� 5      $��WordEllipsis=�6`   $��NoWrap=�6|   ��6!   �� $ Description�$ Description��6|   �� 5      �� 5      ��6$   �� $	 URL�$	 URL�� 6X   �� *NavigateCommand+ 6|   �� $	 URL�.�6�   .�5      �� $��WordEllipsis=�6W   $��NoWrap=�6s   ��6(   �� $	 URL�$	 URL��6s   5       5!      5#      5$      5%      5'      .��5)      �  � RowDefinitions 5*   
   �� 5+      $��* �6   6)   �� 5,      $��52 �6   6*   �� 5-      $��47 �6   6*   .+�50   
   �� $��0��6   .��51      �� -   5         ��Name$ listBox��51   "   $��3q�6   #���  53      ��52      ��  �� Source# [   �� 
GroupStyle 54      (  "System.Windows.Controls.GroupStyle  55         ContainerStyle 56      �� 57       �� 
TargetType" ��6$   .�58   "   ��  �� Property � �� �� Value$ 0,0,0,5q�6;   �� 59   "    � �� 5:   &   �� 5;   *    �� 
TargetType" ��6:   .R�5<   .   9�  9� 
IsExpanded . ���	#FFA4B97F$��0,0,0,1q�6a   ��5=   2   ]� 5>   6   ���#FFE4C9.+�5?   :   �� $��Тип: ��6D   �� 5@   :   $
��Bold"�6D   ��6V   �� $
 Name�5A   7   ��5C   2   �� 5D   6   5F   /   5G   +   5I   #   5J      5L      5N      5O      �� 5R   
   $	 Vertical=�6   $��1��6,   .+�5S      �� $	 
Horizontal=�6   $��Center=�62   .+�5T      ��  �� TextAlignment$ Center=�5U      $��Center=�5V      ��5W      �� $ DownloadInfo��� 5X      $ Center=�6   �� 5Y      ��6$   �� $ DownloadUrl�.�6N   .�5Z      �� $��WordEllipsis=�6L   $��NoWrap=�6h   ��6(   �� $ DownloadUrl�6h   5[      5\      5]      � 5_      $��12��5`      $��5,3,5,0q�5a      $y�Visible=�5c      $��Center=�5d       � Minimum$ 0Q�5e       � Maximum$	 100Q�6    � Value 5b      �� *CurrentProgress+ �� Mode$ OneWay=�5e      � 5g      $��5,5,5,0q�5h      $��12��5i      $y�Visible=�5k      $��Center=�5l      $ 0Q�5m      $	 100Q�6    5j      �� *LocalProgress+$ OneWay=�5m      5n      �� 5o   
   $	 Vertical=�6   $��2��6,   .+�5p      �� $��0,2,5,0q�6;   $��Right=�6L   
 6   �� *ExecutProgram+{�6h   �� *IsOperaEnable+.��6�   )'Запустить/установить6�   �� 5r      $	��200��6   $��25��6$   $��Скачать��60   $��Stretch=�5s      $��Center=�6,   $��Center=�6P   $��SemiBold"�6u   {�5r   B   �� *IsOperaEnable+��5s   �   �� *DownloadCommand+5u      5w      5x      5y      