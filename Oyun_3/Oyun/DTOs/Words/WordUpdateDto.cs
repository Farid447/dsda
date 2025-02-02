﻿using FluentValidation;

namespace Oyun.DTOs.Words;

public class WordUpdateDto
{
    public string Text { get; set; }
    public string LanguageCode { get; set; }
    public IEnumerable<string> BannedWords { get; set; }
}

public class WordUpdateDtoValidator : AbstractValidator<WordUpdateDto>
{
    public WordUpdateDtoValidator()
    {
        RuleFor(x => x.Text)
            .NotEmpty()
            .NotNull()
            .MaximumLength(32);

        RuleFor(x => x.BannedWords)
            .NotNull();

        RuleForEach(x => x.BannedWords)
            .NotNull()
            .MaximumLength(32);
    }
}