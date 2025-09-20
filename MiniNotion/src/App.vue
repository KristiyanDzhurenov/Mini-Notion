<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import type { DefineComponent } from 'vue'
import navbar from './components/navbar.vue'
import Sidebar from './components/Sidebar.vue'
import SearchBar from './components/SearchBar.vue'
import HelloWorld from './components/HelloWorld.vue'
import { ref } from 'vue'

const isDark = ref(false)

function toggleTheme() {
  isDark.value = !isDark.value
  document.documentElement.classList.toggle('dark', isDark.value)
}
</script>

<template>
  <div class="flex">
    <!-- Sidebar - показва се само н екрани md и нагоре -->
     <SearchBar />
     <Sidebаr class="hidden md:block" />

     <!-- Основна част -->
      <div class="flex-1 p-4">
       <header class="flex justify-between items-center mb-4">
        <!-- бутон за смяна на тема-->
        <button @click="toggleTheme" class="p-2 border rounded">
          Смени тема
        </button>
      <img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="125" height="125" />
    </header>
    
      <div class="wrapper">
        <HelloWorld msg="You did it!" />

        <nav>
          <RouterLink to="/">Home</RouterLink>
          <RouterLink to="/about">About</RouterLink>
          <RouterLink to="/pages">Pages</RouterLink>
          <RouterLink to="/blocks">Blocks</RouterLink>
        </nav>
      </div>


    <RouterView />

    </div>
  </div>
</template>

<style scoped>

:root {
  --bg: white;
  --text: black;
}

.dark {
  --bg: #121212;
  --text: #ffffff;
}

body {
  background-color: var(--bg);
  color: var(--text);
}

header {
  line-height: 1.5;
  max-height: 100vh;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  justify-content: space-between;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>

