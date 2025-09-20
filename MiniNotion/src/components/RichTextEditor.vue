<script setup>
import { EditorContent, useEditor } from '@tiptap/vue-3'
import StarterKit from '@tiptap/starter-kit'
import SlashCommand from '../extensions/SlashCommand.js'
import draggale from 'vuedraggable'
import { ref } from 'vue'

const editor = useEditor({
    extensions: [StarterKit, SlashCommand],
    content: '<p>Започни да пишеш...</p>',
})

const blocks = ref([
    { id: 1, text: "Първи блок" },
    { id: 2, text: "Втори блок" },
    { id: 3, text: "Трети блок" },
])
</script>

<template>
    <div class="border rounded p-4">
        <EditorContent :editor="editor" />

        <h3 clss="mt-4 font-bold">Drag & Drop блокове</h3>
        <draggable v-model="blocks" class="space-y-2" item-key="id">
            <template #item="{ element }">
                <div class="p-2 border rounded bg-white">
                    {{ element.text }}
                </div>
            </template>
        </draggable>
    </div>
</template>