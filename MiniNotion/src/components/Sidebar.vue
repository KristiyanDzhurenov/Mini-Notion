<template>
    <aside class="w-64 bg-gray-100 h-screen p-4">
        <h2 class="text-lg font-bold mb-2">Страници</h2>
        <ul>
            <li v-for="page in pages" :key="page.id" class="cursor-pointer hover:bg-gray-200 p-2 rounded">
                <component :is="page.icon" class="w-5 h-5" />
                <span>{{ page.title }}</span>
            </li>
        </ul>
    </aside>
</template>

<script setup lang="ts">
import { defineComponent } from 'vue'
import { ref } from 'vue'
import { HomeIcon, ClipboardDocumentListIcon, PencilSquareIcon } from '@heroicons/vue/24/solid'

const pages = ref([
    { id: 1, title: "Home", icon: HomeIcon },
    { id: 2, title: "Задачи", icon: ClipboardDocumentListIcon },
    { id: 3, title: "Бележки", icon: PencilSquareIcon },
])


</script>

