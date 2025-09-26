<script setup lang="ts">
import { ref } from 'vue';

        const username = ref('');
        const email = ref('');
        const password = ref('');
        const message = ref('');
</script>

<template>
    <div class="register">
        <h2>Register</h2>
            <input v-model="username" type="text" placeholder="Username" required />
            <input v-model="email" type="email" placeholder="Email" required />
            <input v-model="password" type="password" placeholder="Password" required />
        <p>{{ message }}</p>
    </div>
</template>

<style scoped>

</style>

