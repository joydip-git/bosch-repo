   M S B A M L   `   `   `  ����O  KEmployeesViewLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EmployeesViewLibrary.ViewsEmployeesViewLibrary.Views  5      0    *EmployeesViewLibrary.Views.EmployeeRecords   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:EmployeesViewLibrary.Views     5      S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . .��5      � -   5         �Name$ mainGrid��5      .+�5   
   �� $��Select an Employee��6   $
��Left=�6-   $��
53,116,0,0q�6H   $	��Top=�6\   $��29��6t   $	��139��6�   �� 5   
   -   5        $��comboEmployees��5   s   $
��Left=�6   $��234,116,0,0q�6.   $	��Top=�6C   $	��260��6[   $��29��6g    �� DisplayMemberPath$
 Name��6�   ��6�   ��  �� Path$ 	Employees�6�   �� 5   
   -   5        $��btnLoad��5      $
��Load��6   $
��Left=�6    $��543,116,0,0q�6;   $	��Top=�6P   $��93��6h   $��29��6s   ��6�   �� *CommandLoad+� 5   
   -   5        $��employeeGrid��5   �   $
��Left=�6   $	��132��6*   $��
67,181,0,0q�67   $	��Top=�6K   $	��615��6c    � DataContext 6o   ��  �� ElementName$ comboEmployees�� �� UpdateSourceTrigger$ PropertyChanged=�$ SelectedItem� � RowDefinitions 5      �� 5      $	��34* �6    �� 5      $	��46* �6    �� 5      $	��51* �6     � ColumnDefinitions 5      �� 5      $	��78* �6#   �� 5      $
��127* �6#   .+�5      �� $
��ID: ��6   $
��Left=�6#   $��	32,10,0,0q�6>   $	��Top=�6Q   $	��128��6i   $��0��6u   $��0��6�   �� 5       -   5        $��txtId��5    �   $��0��6   $��1��6%   $
��Left=�65   $��
43.6,0,0,0q�6P   $
��Wrap=�6d   $	��Top=�6�   $	��211��6�   $��30��6�   ��6x   �� $ Id�6�   �� 5"      $��NAME: ��6   $
��Left=�6%   $��
32,9.6,0,0q�6@   $	��Top=�6T   $	��128��6l   $��1��6x   $��0��6�   �� 5$      -   5        $��txtName��5$   �   $��1��6   $
��Left=�6&   $��43.6,6.6,0,0q�6A   	 �� TextWrapping$
	 Wrap=�6W   $	��Top=�6�   $	��211��6�   $��30��6�   $��1��6�   ��6k   �� $
 Name�6�   �� 5&      $��SALARY: ��6   $
��Left=�6'   $��32,13.2,0,0q�6B   $	��Top=�6W   $	��128��6o   $��2��6{   $��0��6�   �� 5(      -   5        $��	txtSalary��5(   �   $��1��6   $
��Left=�6&   $��43.6,10.2,0,0q�6A   $
	 Wrap=�6X   $	��Top=�6�   $	��211��6�   $��30��6�   $��2��6�   ��6l   �� $ Salary�6�   5)      5*      5+      