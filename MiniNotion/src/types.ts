export interface Page {
    id: number;
    title: string;
    userId: number;
}

export interface Block {
    id: number;
    pageId: number;
    type: string;
    content: string;
    position: number;
}