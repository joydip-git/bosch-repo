   M S B A M L   `   `   `  ����J  Fwpf_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:wpf_DataBindingwpf_DataBinding  5   	   G(clr-namespace:wpf_DataBinding.Converterswpf_DataBinding.Converters  5   	        wpf_DataBinding.DataWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:wpf_DataBinding     5   	   ?
converters(clr-namespace:wpf_DataBinding.Converters     5   	   -   5          � Title$  
DataWindow��5	   	   $��509.542��6   $��979.771��6-    � 	Resources 5      0   *wpf_DataBinding.Converters.SalaryConverter   salConveter��%   &	          5   
   6%   5      .��5      � -   5         �Name$ mainGrid��5      .+�5   
   �� $��Select a Person��6   $
��Left=�6*   $��	95,39,0,0q�6E   $	��Top=�6X   �� 5   
   -   5        $��comboPeople��5   r   $
��Left=�6   $��
236,39,0,0q�6.   $	��Top=�6B   $	��218��6Z   $��26��6f   6r   � 5   
   -   5        $��
gridPerson��5   o   $
��Left=�6   $	��263��6*   $��
118,96,0,0q�67   $	��Top=�6K   $	��546��6c    � DataContext 5      ��  �� ElementName$ comboPeople�� �� Path$ SelectedItem� � ColumnDefinitions 5      �� 5      $��179.2 �6#   �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5       .+�5#      �� $��Id��6   $
��Left=�6!   $��	54,33,0,0q�6<   $	��Top=�6O   $��0��6g   $��0��6t   �� 5$      $
��Name��6   $
��Left=�6#   $��	54,33,0,0q�6>   $	��Top=�6Q   $��1��6i   $��0��6v   �� 5%      $��Salary��6   $
��Left=�6%   $��	54,24,0,0q�6@   $	��Top=�6S   $��2��6k   $��0��6x   �� 5'      -   5        $��txtId��5'   �   $��1��6   $��0��6(   $
��Left=�65   $��28.8,33,0,0q�6P   $
��Wrap=�6e   $	��Top=�6�   $��45��6�   $	��290��6�   ��6y   �� $ Id���5(      �� 5)       �� Color# � ��6&   5+      �� 5-      -   5        $��txtName��5-   �   $��1��6   $��1��6&   $
��Left=�63   $��28.8,33,0,0q�6N   	 �� TextWrapping$
	 Wrap=�6c   $	��Top=�6�   $��45��6�   $	��290��6�   ��6w   �� $
 Name�
 �� UpdateSourceTrigger$
 PropertyChanged=�.��6�   ��5.      �� 5/      # � ��6&   .��50   &   51      �� 5M      -   5        $��	txtSalary��5M   �   $��1��6   $��2��6&   $
��Left=�63   $��28.8,33,0,0q�6N   $
	 Wrap=�6c   $	��Top=�6w   $��45��6�   $	��290��6�   .��6�   ��5N      �� 5O      # � �6&   .��5P   &   ��5Q      �� 5R      $ Salary�6    �� NotifyOnValidationError . $
 PropertyChanged=�6K    �� 	Converter# [  6q    �� ValidationRules 5S      5  /System.Windows.Controls.ExceptionValidationRule  5T      68   5V      .��5W       5X      5Y      �� 5Z   
   -   5        $��Check��5Z      $
��Left=�6!   $��396,415,0,0q�6<   $	��Top=�6Q   $	��117��6i   $��41��6u   6�   �� 5[   
   -	   5        $��btnIncrease��5[   �   $��Increase Salary��6   $
��Left=�6+   $��584,415,0,0q�6F   $	��Top=�6[   $	��145��6s   $��41��6   6�   5]      5_      