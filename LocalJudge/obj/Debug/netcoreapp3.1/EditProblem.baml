   M S B A M L   `   `   `  ����E  ALocalJudge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:LocalJudge
LocalJudge  5   	       LocalJudge.EditProblem   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:LocalJudge     5   	     � Title$  EditProblem��5   	   $	��450��6   $	��800��6*   
�������.��5	      � .+�5
   
   �� $
��Left=�6   $��	63,29,0,0q�6/   $��Edit Problem��6B   $��14(�6V   $
��Wrap=�6d   $	��Top=�6x   �� 5   
   $
��Left=�6   $��	63,69,0,0q�6/   $��Title:��6B   $
��Wrap=�6P   $	��Top=�6d   �� 5   
   -   5         ��Name$ Title_TextBox��5      $
��Left=�6)   $��
144,69,0,0q�6D   $�� ��6X    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��150��6�   $��18��6�   �� 5   
   $
��Left=�6   $��	63,99,0,0q�6/   $��Content:��6B   $
��Wrap=�6R   $	��Top=�6f   �� 5   
   -   5        $ Content_TextBox��5      $
��Left=�6+   $��
144,99,0,0q�6F   $�� ��6Z   $
 Wrap=�6b   $	��Top=�6v   $	��150��6�   $��56��6�   �� 5   
   $
��Left=�6   $��
63,169,0,0q�6/   $��Difficulty:��6C   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   -   5         ��Name$ Difficulty_ComboBox��5      $
��Left=�60   $��144,169,0,0q�6K   $	��Top=�6`   $	��150��6x   �� 5   
   $
��Left=�6   $��
63,239,0,0q�6/   $��Input:��6C   $
��Wrap=�6Q   $	��Top=�6e   �� 5   
   -   5        $ Input_TextBox��5      $
��Left=�6)   $��144,239,0,0q�6D   $�� ��6Y   $
 Wrap=�6a   $	��Top=�6u   $	��150��6�   $��18��6�   �� 5   
   $
��Left=�6   $��
63,269,0,0q�6/   $��Output:��6C   $
��Wrap=�6R   $	��Top=�6f   �� 5   
   -   5        $ Output_TextBox��5      $
��Left=�6*   $��144,269,0,0q�6E   $�� ��6Z   $
 Wrap=�6b   $	��Top=�6v   $	��150��6�   $��18��6�   �� 5   
   $
��Left=�6   $��
63,212,0,0q�6/   $��Add Test Case��6C   $
��Wrap=�6X   $	��Top=�6l   �� 5   
   -   5         ��Name$ 
Add_Button��5      $�� Add ��6%   $
��Left=�65   $��255,299,0,0q�6P   $	��Top=�6e   $��39��6}   6�   �� 5   
   -   5         ��Name$ Testcase_ListView��5      $��345,99,100,115q�6.   ��6F   �� *	testcases+ �� View 5      �� 5      .P�5      ��  �� Width$	 130��6%   $��Input��61    �� DisplayMemberBinding 6@   �� *Input+�� 5      $	 230��6%   $��Output��61    6A   �� *Output+5      5      �� 5   
   $
��Left=�6   $��
345,69,0,0q�6/   $��
Test Cases��6C   $��13(�6U   $
��Wrap=�6c   $	��Top=�6w   �� 5    
   -   5        $ Save_Button��5       $
��Save��6&   $��14(�65   $
��Left=�6C   $��
63,351,0,0q�6^   $	��Top=�6r   $��33��6�   $��96��6�   6�   �� 5!   
   -	   5        $ Logout_Button��5!      $��Logout��6(   $��14(�69   $
��Left=�6G   $��
650,29,0,0q�6b   $	��Top=�6v   $��25��6�   $��75��6�   6�   �� 5"   
   -
   5        $ GoBack_Button��5"      $��Go Back��6(   $��14(�6:   $
��Left=�6H   $��
549,29,0,0q�6c   $	��Top=�6w   $��25��6�   $��76��6�   6�   �� 5#   
   -   5        $ Remove_Button��5#      $��Remove��6(   $
��Left=�69   $��640,326,0,0q�6T   $	��Top=�6i   $��56��6�   6�   5$      5%      