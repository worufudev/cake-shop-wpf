   M S B A M L   `   `   `  ����C  ?CakeShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CakeShopCakeShop  5   	       CakeShop.MainScreen   5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CakeShop     5   	   -   5          �Name$  
mainScreen��5	   	   ���#333333$
��1280��5   	   $	��720��5   	    � Icon$&  Assets/Icons/ApplicationIcon.ico��5   	    � Title$ We Split��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � ShowActivated . .��5      � .+�5   
   �� ���#4C5969$��1q�5      ._�5      ]� ��. .+�5      � -   5         �Name$ titleBar��5      $	��Top=�5      ���#000000.+�5      �� $��Right=�6!    �� Orientation$ 
Horizontal=�5   !   .+�5      �� -   5        	 ��Name$	 aboutButton��5   !   
������ $��0q�5!   !   $��5q�5"   !   .��5$      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Settings=�66   5%      �� 5&      -   5        $	 settingsButton��5&   !   
������ $��0q�5(   !   $��5q�5)   !   .��5+        $
 Information=�66   5,      �� 5-      -   5        $	 minimizeWindowButton��5-   !   
������ $��0q�5/   !   $��5q�50   !   .��52        $
 WindowMinimize=�66   53      �� 54      -   5        $	 closeWindowButton��54   !   
������ $��0q�56   !   $��5q�57   !   .��59        $
 Shutdown=�66   5:      5;      �� 5<      $
��Left=�6!   $ 
Horizontal=�5=   !   .+�5>      d� -   5         d�Name$ 
menuButton��5>   '   ���#FAFAFA$��20��5@   '   $��20��5A   '    '  #MaterialDesignHamburgerToggleButton#���   5B   '   �� 5C      $��Center=�6$   $��5 0 0 0q�5D   $    �� Padding$ 2q�5E   $   ���#FFFFFF$��Cake Shop Beta��5G   $   $��Tahoma)�5H   $   $��Heavy"�5I   $   $��15(�5J   $   5K      5L      � 5M      .+�5N      � -   5        $ mainGrid��5N      5P      )  #MaterialDesignThemes.Wpf.DrawerHost  5Q         IsLeftDrawerOpen 60   ��  �� ElementName$ 
menuButton�� �� Path$ 	IsChecked�   LeftDrawerContent 5R      �� 5S      ���#484848.+�5T   "   �� $��Center=�6(   $)��#Assets/Icons/ApplicationBigIcon.ico��5U   (    �� BitmapScalingMode$ HighQuality=�5V   (   $��96��5W   (   $��96��5X   (   �� 5Y   "   -	   5         ��Name$ menuBox��5Y   *    �� SelectedIndex$ 0��5Z   *   .@�5\   &   �� $��0 5 0 0q�61   $ 
Horizontal=�5]   1   .+�5^   *     $

 Home=�6B   ���#FAFAFA5_   B   �� 5`   *   $	��5 0q�64   ���#FAFAFA$��Tahoma)�5b   4   $��15(�5c   4   Trang chủ5e   +   5f   '   �� 5g   &   $��0 5 0 0q�61   $ 
Horizontal=�5h   1   .+�5i   *     $
 CashUsd=�6B   ���#FAFAFA5j   B   �� 5k   *   $	��5 0q�64   ���#FAFAFA$��Tahoma)�5m   4   $��15(�5n   4   Xem doanh thu5p   +   5q   '   �� 5r   &   $��0 5 0 0q�61   $ 
Horizontal=�5s   1   .+�5t   *     $	
 Add=�6B   ���#FAFAFA5u   B   �� 5v   *   $	��5 0q�64   ���#FAFAFA$��Tahoma)�5x   4   $��15(�5y   4   Tạo hóa đơn5{   +   5|   '   5}   #   5~      5�      5�      5�      5�      5�      5�      