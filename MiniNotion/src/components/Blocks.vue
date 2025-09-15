<script setup lang="ts">
import { ref, onMounted } from "vue";
import api from "../api";
import type { Block } from "../types";

// получаване на id на страницата като пропс
const props = defineProps<{ pageId: number }>();

const blocks = ref<Block[]>([]);
const newContent = ref("");

// Зарежда блокове за дадена страница
const loadBlocks = async () => {
    const res = await api.get<Block[]>(`/blocks/page/${props.pageId}`);
    blocks.value = res.data;
};

// Създава нов блок
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

// Триене на блок

</script>