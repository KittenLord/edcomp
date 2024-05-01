public enum TokenType
{
    EOF,
    Illegal,


    LParen, RParen,
    LCurly, RCurly,
    LBrack, RBrack,


    Fn,
    Cfn,
    Call,
    Let,
    Mut,
    Ret,
    If,
    Else,
    While,
    Do,


    Plus, Minus, Mul, Div, Mod,
    Eq, Neq, Ge, Le, Gr, Ls,
    Not, 
    Assign,
    Comma,


    Id,
    IntLit,
    StrLit,
    BoolLit,
}
