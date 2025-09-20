<template>
    <input v-model="query" type="text" placeholder="Търси..." class="w-full border p-2 rounded" />
</template>

<script setup>
import { ref, watch } from 'vue'

const query = ref('')

watch(query, (val) => {
    console.log("Търсене:", val)
})

</script>