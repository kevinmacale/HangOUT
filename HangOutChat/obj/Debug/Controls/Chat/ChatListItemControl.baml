   M S B A M L   `   `   `  ����F  BHangOutChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HangOutChat.WordHangOutChat.Word  5      K GHangOutChat.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW=clr-namespace:HangOutChat.Word.Core;assembly=HangOutChat.CoreHangOutChat.Word.Core 5      *    $HangOutChat.Word.ChatListItemControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:HangOutChat.Word     5      Ncore=clr-namespace:HangOutChat.Word.Core;assembly=HangOutChat.Core     5      $��60��5	        � 	Resources  5      3   -HangOutChat.Word.BooleanToVisibilityConverter  5   
      Key BooleanToVisibilityConverter  6-   �� 5   
   ContentStyle   �� 
TargetType" ��6%   .�5      ��  �� Property � �� �� Value 5      �� 5       �� 
TargetType" ��6&   .R�5      ��  ��Name$ 
background��6!     ForegroundLightBrush#��[ 65   ._�5      �  �Name$ 	container��6#   
������  � ColumnDefinitions 5   "   �� 5   &   $
��Auto �67   �� 5   &   $��* �67   .+�5   "   �� 
���  ��$��4��6:   $
��Left=�6D   y�5   %   �� *NewContentAvailable+   BooleanToVisibilityConverter �� 	Converter# [ 	 �� ConverterParameter$
	 True��5   #   �� 5    "   $��0��6)   
 �� Padding$
 5q�69   ._�5"   &   �� ��6-   �� *ProfilePictureRGB+ 0   *HangOutChat.Word.StringRGBToBrushConverter  ��5#   )   �� *ActualHeight+ �� RelativeSource �� *Self+ �� CornerRadius 5$   )   �� *ActualHeight+ �� *Self+._�5%   *   �� $��Center=�5&   0   $��Center=�5'   0   #��[ 5(   0     FontSizeAverage#��[ 5)   0     LatoRegular#��[ 5*   0   ��5%   4   �� *
Initials+5*   0   5+   '   5,   #   �� 5/   "   $��1��6)   $
 0,0,8,0q�69   ._�50   &   ��  �� Orientation$ Vertical=�61   $��Center=�6H   .+�52   *   ��  ��Name$
 name��64   #��[ 6X     WordBlueBrush#��[ 53   0   ��52   B   �� *Name+53   0   �� 55   *   $ message��64   #��[ 6^     ForegroundDarkBrush#��[ 56   0   $��CharacterEllipsis=�57   0   ��55   E   �� *	Message+57   0   58   '   59   #   5:      5;       �� Triggers 5>      �� 5?       �� Value$
 True��6I    �� Binding 6*   �� *
IsSelected+.a�5@   "   ��  �� 
TargetName$ 
background��6?    � �� �	#FF4BA8EB6W   �� 5A   "   $ message��6?    � ��
 �����6T   �� 5B   "   $
 name��6?    � ��
 �����6Q   5C      :� 5D       :� RoutedEvent$ 
MouseEnter��6+   .[�5E   "   �� .��5F   &   �� .��5G   *   ��   WordVeryLightBlue	 �� To# [ 69    g� Duration$ 0:0:0.5D�6a    �� 
TargetName$ 	container��6t    �� TargetProperty$ Background.Color�5H   5   5I   '   5J   #   5K      :� 5L      $ 
MouseLeave��6+   .[�5M   "   �� .��5N   &   �� .��5O   *   �� $ TransparentX�69   $ 0:0:0.5D�6J   $ 	container��6]   $ Background.Color�5P   5   5Q   '   5R   #   5S      P� 5T       P� Property � {� P� Value .  . �5U   "   �� $ 	container��6?    � �� �	#FFF4F4F46V   5V      5X      5[      5\      .��5_      ��   ContentStyle#��[ 6V   5a      5d      