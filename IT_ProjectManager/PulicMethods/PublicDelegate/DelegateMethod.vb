Module DelegateMethod
    ''------winForm窗体委托处理-------------------------------------------------------------------
    ''' <summary>
    ''' 公共from的委托
    ''' </summary>
    ''' <param name="frm">Win窗体</param>
    ''' <remarks></remarks>
    Public Delegate Sub SetFrmDelegate(ByVal frm As System.Windows.Forms.Form)

    ''' <summary>
    ''' 针对Frm实例化委托
    ''' </summary>
    ''' <remarks></remarks>
    Public SetFrm As SetFrmDelegate


    ''------自定义窗体委托处理-------------------------------------------------------

    ''' <summary>
    ''' 公共from的委托
    ''' </summary>
    ''' <param name="UCfrm">自定义窗体</param>
    ''' <remarks></remarks>
    Public Delegate Sub SetUCDelegate(ByVal UCfrm As System.Windows.Forms.UserControl)

    ''' <summary>
    ''' 实例化自动定义窗体委托
    ''' </summary>
    ''' <remarks></remarks>
    Public SetUC As SetUCDelegate

    ''----------GridView控件委托处理-----------------------------------------------------------------

    ''' <summary>
    ''' 定义一个仅供委托
    ''' </summary>
    ''' <param name="GridControl">Grid控件</param>
    ''' <param name="dt">DT数据集</param>
    ''' <remarks>没有返回参数</remarks>
    Public Delegate Sub SetGridViewDelegate(ByVal GridControl As DevExpress.XtraGrid.GridControl, ByVal dt As Object)

    ''' <summary>
    ''' 实例化委托
    ''' </summary>
    ''' <remarks></remarks>
    Public SetGridData As SetGridViewDelegate

    ''---绑定值 

    ''' <summary>
    ''' 定义一个仅供委托
    ''' </summary>
    ''' <param name="dt">DT数据集</param>
    ''' <remarks>没有返回参数</remarks>
    Public Delegate Sub SetTextDelegate(ByVal dt As Object)

    ''' <summary>
    ''' 实例化委托
    ''' </summary>
    ''' <remarks></remarks>
    Public SetTextData As SetTextDelegate

    ''-----------------------
    ''' <summary>
    ''' 定义一个仅供委托
    ''' </summary>
    ''' <param name="GridControl">Grid控件</param>
    ''' <param name="dt">DT数据集</param>
    ''' <remarks>没有返回参数</remarks>
    Public Delegate Sub SetLockUpEditDelegate(ByVal GridControl As DevExpress.XtraEditors.LookUpEdit, ByVal dt As Object)

    Public Delegate Sub SetGridLookUpEditDelegate(ByVal GridControl As DevExpress.XtraEditors.GridLookUpEdit, ByVal dt As Object)

    ''' <summary>
    ''' 实例化委托
    ''' </summary>
    ''' <remarks></remarks>
    Public SetLockUpEdit As SetLockUpEditDelegate

    Public SetGridLookUpEdit As SetGridLookUpEditDelegate

    ''-----------treelist------------
    ''' <summary>
    ''' 定义一个仅供委托
    ''' </summary>
    ''' <param name="GridControl">Grid控件</param>
    ''' <param name="dt">DT数据集</param>
    ''' <remarks>没有返回参数</remarks>
    Public Delegate Sub SetTreeListDelegate(ByVal GridControl As DevExpress.XtraTreeList.TreeList, ByVal dt As Object)

    ''' <summary>
    ''' 实例化委托
    ''' </summary>
    ''' <remarks></remarks>
    Public SetTreeList As SetTreeListDelegate

    '' ------------------------------------DataSet
    ''' <summary>
    ''' 定义一个DataSet的公共委托
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Public Delegate Sub SetDataSetDelegate(ByVal ds As DataTable, ByVal dt As DataTable)
    ''' <summary>
    ''' 实例化DataSet
    ''' </summary>
    ''' <remarks></remarks>
    Public SetDataSet As SetDataSetDelegate

End Module
