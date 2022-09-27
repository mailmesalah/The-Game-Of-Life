<Serializable()> Public Class COrganismPlaceHolder
    Public isInitialGOrganismExist As Boolean
    Public isCurrentGOrganismExist As Boolean
    Public isNextGOrganismExist As Boolean

    Public Sub New()
        MyBase.New()
        isInitialGOrganismExist = False
        isCurrentGOrganismExist = False
        isNextGOrganismExist = False

    End Sub
End Class
