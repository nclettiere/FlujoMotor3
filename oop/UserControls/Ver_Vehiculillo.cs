
internal void Data(Info_de_Autillos info_de_Autillos, string vin, ref ODBC Conexion)
{
    InfoAutos = info_de_Autillos;
    DataTable resultado = Conexion.consultar("SELECT * FROM vehiculos WHERE vehiculovin=" + vin);

    var[log == new LoggerConfiguration()];
    ;
#error Cannot convert ExpressionStatementSyntax - see comment for details
    /* Cannot convert ExpressionStatementSyntax, System.InvalidOperationException: Stack empty.
       at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
       at System.Collections.Generic.Stack`1.Peek()
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.<>c__DisplayClass131_0.<VisitInvocationExpression>g__ConvertInvocationSubExpression|0(Boolean& isElementAccess)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitInvocationExpression(InvocationExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitExpressionStatement(ExpressionStatementSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.ByRefParameterVisitor.AddLocalVariables(VisualBasicSyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.ByRefParameterVisitor.VisitExpressionStatement(ExpressionStatementSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

    Input: 
                .WriteTo.Console()

     */
    ;
#error Cannot convert ExpressionStatementSyntax - see comment for details
    /* Cannot convert ExpressionStatementSyntax, System.InvalidOperationException: Stack empty.
       at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
       at System.Collections.Generic.Stack`1.Peek()
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.<>c__DisplayClass131_0.<VisitInvocationExpression>g__ConvertInvocationSubExpression|0(Boolean& isElementAccess)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitInvocationExpression(InvocationExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitExpressionStatement(ExpressionStatementSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.ByRefParameterVisitor.AddLocalVariables(VisualBasicSyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.ByRefParameterVisitor.VisitExpressionStatement(ExpressionStatementSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

    Input: 
                .WriteTo.File("log.txt")

     */
    ;
#error Cannot convert ExpressionStatementSyntax - see comment for details
    /* Cannot convert ExpressionStatementSyntax, System.InvalidOperationException: Stack empty.
       at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
       at System.Collections.Generic.Stack`1.Peek()
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.<>c__DisplayClass131_0.<VisitInvocationExpression>g__ConvertInvocationSubExpression|0(Boolean& isElementAccess)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitInvocationExpression(InvocationExpressionSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitExpressionStatement(ExpressionStatementSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.ByRefParameterVisitor.AddLocalVariables(VisualBasicSyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.ByRefParameterVisitor.VisitExpressionStatement(ExpressionStatementSyntax node)
       at Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
       at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
       at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

    Input: 
                .CreateLogger();

     */
    log.Information("Hello, Serilog!");/* TODO ERROR: Skipped SkippedTokensTrivia */

    lblVin.Text = resultado.Rows[0][0];
}
