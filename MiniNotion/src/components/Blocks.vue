<script setup lang="ts">
import { ref, onMounted } from "vue";
import api from "../api";
import type { Block } from "../types";

const props = defineProps<{ pageId: number }>();

const blocks = ref<Block[]>([]);
const newContent = ref("");

const loadBlocks = async () => {
    const res = await api.get<Block[]>(`/blocks/page/${props.pageId}`);
    blocks.value = res.data;
};


const addBlock = async () => {
    if (!newContent.value.trim()) return;
    const res = await api.post<Block[]>("blocks", {
        pageId: props.pageId,
        type: "text",
        content: newContent.value,
        position: blocks.value.length,
    });
    blocks.value.push(...res.data);
    newContent.value = "";
};


const deleteBlock = async (id: number) => {
    await api.delete(`/blocks/${id}`);
    blocks.value = blocks.value.filter((b) => b.id !== id);
};

onMounted(() => {
    loadBlocks();
});                                            
</script>

<template>
    <div>
        <div>
            <h2>Blocks</h2>
        </div>
        <input v-model="newContent" placeholder="New block..." />
        <button @click="addBlock">Add</button>

        <ul>
            <li v-for="block in blocks" :key="block.id">
                {{ block.content }}
                <button @click="deleteBlock(block.id)">Delete</button>
            </li>
        </ul>
    </div>
</template>


<script lang="ts">
export default {};
</script>