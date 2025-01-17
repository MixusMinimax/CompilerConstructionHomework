﻿namespace Common.Models;

public record Letter(char Character) : RegexTree
{
    public override bool Empty => false;

    private ISet<Letter>? _first;
    public override ISet<Letter> First => _first ??= new HashSet<Letter>(new[] { this });

    public override ISet<Letter> Next
    {
        set => NextBackingField = value;
    }
    
    

    private ISet<Letter>? _last;
    public override ISet<Letter> Last => _last ??= new HashSet<Letter>(new[] { this });

    private IEnumerable<Letter>? _letters;
    public override IEnumerable<Letter> Letters => _letters ??= new[] { this };

    public override string RegexString { get; } = $"{Character}";
}
