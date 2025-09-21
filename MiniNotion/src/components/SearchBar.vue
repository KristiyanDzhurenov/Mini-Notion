<template>
    <input v-model="query" type="text" placeholder="Търси..." class="" />
</template>

<script setup>
import { ref, watch } from 'vue'

const query = ref('')

watch(query, (val) => {
    console.log("Търсене:", val)
})

</script>