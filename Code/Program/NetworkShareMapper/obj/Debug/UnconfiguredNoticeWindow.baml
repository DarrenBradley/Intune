   M S B A M L   `   `   `  ����M  INetworkShareMapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NetworkShareMapperNetworkShareMapper  5      1    +NetworkShareMapper.UnconfiguredNoticeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:NetworkShareMapper     5      -   5        $!��winUnconfiguredNoticeWindow��5	   	   $	��300��6,   $	��500��69     � 
ResizeMode$  CanMinimize=�6E    � Title$0 *Intune Network Drive mapping is not ready.��6^   $y�Visible=�6�    � WindowStyle$ 
ToolWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5
      � .+�5   
   �� -   5        $��
lblHeading��5      $4��.Intune Network Drive mapping is not ready yet.��6"   $
��Left=�6[   $��	50,40,0,0q�6v   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   $	��400��6�   �� 5   
   -   5        $��
lblMessage��5      $
��Wrap=�6&   $����We haven't received an active configuration from the device management yet.

If you are an administrator you should check your Intune configuration and assign an active profile to this device.��6:   $
��Left=�6
  $��98��6%  $��	50,76,0,0q�61  $	��Top=�6D  $	��400��6\  {�.   �� TextAlignment$
 Left=�6z  �� 5   
   -   5        $��Close��5      $
��Left=�6!   $��350,180,0,0q�6<   $	��Top=�6Q   $��28��6i   $	��100��6u    �� IsCancel .  �� 	IsDefault . 6�   �� 5   
   -   5        $��lblAdminGuide��5   c   $��28��6   $��
50,180,0,0q�6   $
��Left=�60   $	��Top=�6K   .��5      �� -   5        $M��Ghttps://github.com/Weatherlights/Intune-Network-Drive-Mapping-Tool/wiki?�5   D   .�6�   Administrator documentation5      5      5      5      