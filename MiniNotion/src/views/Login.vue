<script setup lang="ts">
import { ref } from 'vue';
import axios from 'axios';
import { useRouter } from 'vue-router';
const email = ref('');
const password = ref('');
const message = ref('');
const router = useRouter()

const loginUser = async () => {
    try {
        const response = await axios.post('http://localhost:5000/login', {
            email: email.value,
            password: password.value
        });
        message.value = response.data.message || 'Logged in successfully!';
        localStorage.setItem('token', response.data.token);
        router.push('/');
    } catch (error: unknown) {
        if (axios.isAxiosError(error)) {
            message.value = error.response?.data?.message || 'Login failed';
        } else if (error instanceof Error) {
            message.value = 'Login failed';
        }
    }
};
</script>

<template>
    <div class="login">
        <h2>Login</h2>
        <form @submit.prevent="loginUser">
            <input v-model="email" type="email" placeholder="Email" required />
            <input v-model="password" type="password" placeholder="Password" required />
            <button type="submit">Login</button>
        </form>
        <p v-if="message">{{ message }}</p>
    </div>
</template>

<style scoped>

</style>