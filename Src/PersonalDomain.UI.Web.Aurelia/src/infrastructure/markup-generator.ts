import * as marked from 'marked';
import * as hljs from 'highlight.js';

export class MarkupGenerator {
	public static GenerateMarkup(markdown: string) : string {
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

        return marked.parse(markdown, markedOptions) 	
	}
	
    public static HighlightCodeBlock(code: string, language: string): string {
        var highlightResult = language ? hljs.highlight(language, code) : hljs.highlightAuto(code);
        return highlightResult.value;
    }	
}