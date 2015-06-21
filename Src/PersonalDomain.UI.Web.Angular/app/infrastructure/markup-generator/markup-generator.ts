class MarkupGenerator {
    public static GenerateMarkup: (markdown: string) => string = (markdown) => {
        if (!markdown) {
            return "";
        }

        var markedOptions: MarkedOptions = {
            gfm: true,
            tables: true,
            breaks: false,
            pedantic: false,
            sanitize: true,
            smartLists: true,
            highlight: MarkupGenerator.HighlightCodeBlock,
            smartypants: false
        }

        return marked(markdown, markedOptions);
    }

    public static HighlightCodeBlock: (code: string, language: string) => string = (code, language) => {
        var highlightResult = language ? hljs.highlight(language, code) : hljs.highlightAuto(code);
        return highlightResult.value;
    }
}

export = MarkupGenerator; 