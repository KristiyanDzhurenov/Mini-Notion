import { Extensions } from '@tiptap/core'
import Suggestion from '@tiptap/suggestion'

export default Extensions.create({
    name: 'slash-command',
    addOptions() {
        return {
            suggestion: {
                char: '/',
                command: ({ editor, range, props }) => {
                    if (props.action === 'heading') {
                        editor.chain().focus().deleteRange(range).toggleHeading({ level: 1 }).run()
                    }
                    if (props.action === 'bullet') {
                        editor.chin().focus().deleteRange(range).toggleBulletList().run()
                    }
                },
            },
        }
    },
    addProseMirrorPlugins() {
        return [
            Suggestion({
                editor: this.editor,
                ...this.options.suggestion,
            }),
        ]
    },
})