<script setup lang="ts">
import { ref, onMounted } from "vue";
import api from "../api";
import type { Page } from "../types";

const pages = ref<Page[]>([]);
const newTitle = ref("");

// Зарежда всички страници
const loadPages = async () => {
    const res = await api.get<Page[]>("/pages");
    pages.value = res.data;
};

// Създаване на нова страница
const createPage = async () => {
    if(!newTitle.value.trim()) return;
    const res = await api.post<Page>("/pages", {
        title: newTitle.value,
        userId: 1, // временно userId=1
    });
    pages.value.push(res.data);
    newTitle.value = "";
};

// Изтрива страница
const deletePage = async (id: number) => {
    await api.delete('/pages/${id}');
    pages.value = pages.value.filter((p) => p.id !== id);
};

onMounted(() => {
    loadPages();
});
</script>

<template>
    <div>
        <h1>Pages</h1>

        <div>
            <input v-model="newTitle" placeholder="Page title..." />
            <button @click="createPage">Create</button>
        </div>

        <ul>
            <li v-for="page in pages" :key="page.id">
                {{ page.title }}
                <button @click="deletePage(page.id)">Delete</button>
            </li>
        </ul>
    </div>
</template>