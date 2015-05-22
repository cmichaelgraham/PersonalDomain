// Type definitions for highlight.js v8.2.0
// Project: https://github.com/isagalaev/highlight.js
// Definitions by: Niklas Mollenhauer <https://github.com/nikeee/>, Jeremy Hull <https://github.com/sourrust>
// Definitions: https://github.com/borisyankov/DefinitelyTyped

declare var hljs: highlightStatic;

interface highlightStatic {
    highlight(name: string, value: string, ignore_illegals?: boolean, continuation?: boolean): IHighlightResult;
    highlightAuto(value: string, languageSubset?: string[]): IAutoHighlightResult;

    fixMarkup(value: string): string;

    highlightBlock(block: Node): void;

    configure(options: IOptions): void;

    initHighlighting(): void;
    initHighlightingOnLoad(): void;

    registerLanguage(name: string, language: (hljs?: HLJSStatic) => IModeBase): void;
    listLanguages(): string[];
    getLanguage(name: string): IMode;

    inherit(parent: Object, obj: Object): Object;
}

interface IHighlightResultBase {
    relevance: number;
    language: string;
    value: string;
}

interface IAutoHighlightResult extends IHighlightResultBase {
    second_best?: IAutoHighlightResult;
}

interface IHighlightResult extends IHighlightResultBase {
    top: ICompiledMode;
}

interface HLJSStatic {
    inherit(parent: Object, obj: Object): Object;

    // Common regexps
    IDENT_RE: string;
    UNDERSCORE_IDENT_RE: string;
    NUMBER_RE: string;
    C_NUMBER_RE: string;
    BINARY_NUMBER_RE: string;
    RE_STARTERS_RE: string;

    // Common modes
    BACKSLASH_ESCAPE: IMode;
    APOS_STRING_MODE: IMode;
    QUOTE_STRING_MODE: IMode;
    PHRASAL_WORDS_MODE: IMode;
    C_LINE_COMMENT_MODE: IMode;
    C_BLOCK_COMMENT_MODE: IMode;
    HASH_COMMENT_MODE: IMode;
    NUMBER_MODE: IMode;
    C_NUMBER_MODE: IMode;
    BINARY_NUMBER_MODE: IMode;
    CSS_NUMBER_MODE: IMode;
    REGEX_MODE: IMode;
    TITLE_MODE: IMode;
    UNDERSCORE_TITLE_MODE: IMode;
}

// Reference:
// https://github.com/isagalaev/highlight.js/blob/master/docs/reference.rst
interface IModeBase {
    className?: string;
    aliases?: string[];
    begin?: string;
    end?: string;
    case_insensitive?: boolean;
    beginKeyword?: string;
    endsWithParent?: boolean;
    lexems?: string;
    illegal?: string;
    excludeBegin?: boolean;
    excludeEnd?: boolean;
    returnBegin?: boolean;
    returnEnd?: boolean;
    starts?: string;
    subLanguage?: string;
    subLanguageMode?: string;
    relevance?: number;
    variants?: IMode[];
}

interface IMode extends IModeBase {
    keywords?: any;
    contains?: IMode[];
}

interface ICompiledMode extends IModeBase {
    compiled: boolean;
    contains?: ICompiledMode[];
    keywords?: Object;
    terminators: RegExp;
    terminator_end?: string;
}

interface IOptions {
    classPrefix?: string;
    tabReplace?: string;
    useBR?: boolean;
    languages?: string[];
}

declare module "highlight.js" {
    export = hljs;
}
